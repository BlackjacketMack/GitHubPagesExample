using GitHubPagesExample.Pages;
using GitHubPagesExample.Pages.Blog.Posts;

namespace GitHubPagesExample.Services
{
    interface IArticleHelper
    {
        IEnumerable<BlogArticle> GetBlogArticles() => GetArticles().OfType<BlogArticle>();
        IEnumerable<TechnologyArticle> GetTechnologyArticles() => GetArticles().OfType<TechnologyArticle>();
        IEnumerable<Article> GetRecentArticles();
        IEnumerable<Article> GetArticles();
    }

    public class ArticleHelper : IArticleHelper
    {



        public IEnumerable<Article> GetRecentArticles()
        {
            return GetArticles();
        }

        public IEnumerable<Article> GetArticles()
        {
            var posts = new List<Article>();

            var postTypes = typeof(ArticleHelper).Assembly.GetTypes().Where(w =>
                                                                !w.IsAbstract &&
                                                                w.IsAssignableTo(typeof(Article)) &&
                                                                !w.Name.EndsWith("_Imports"));

            foreach (var postType in postTypes)
            {
                var instance = Activator.CreateInstance(postType) as Article;
                if (instance == null) continue;
                posts.Add(instance);
            }

            return posts;
        }
    }
}
