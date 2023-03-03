using GitHubPagesExample.Pages;

namespace GitHubPagesExample.Services
{
    interface IArticleHelper
    {
        T? FindArticle<T>(string key) where T : Article => FindArticle(key) as T;
        IEnumerable<T> GetArticles<T>() where T : Article => GetArticles().OfType<T>();

        Article? FindArticle(string key);
        IEnumerable<Article> GetArticles();
    }

    public class ArticleHelper : IArticleHelper
    {
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

        public Article? FindArticle(string key)
        {
            return GetArticles().Where(w => w.Key == key).SingleOrDefault();
        }
    }
}
