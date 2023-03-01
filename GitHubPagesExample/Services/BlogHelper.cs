using GitHubPagesExample.Pages.Blog.Posts;

namespace GitHubPagesExample.Services
{
    interface IBlogHelper
    {
        IEnumerable<BlogPostPage> GetRecentPosts();
        IEnumerable<BlogPostPage> GetAllPosts();
    }

    public class BlogHelper : IBlogHelper
    {
        public IEnumerable<BlogPostPage> GetRecentPosts()
        {
            return GetAllPosts();
        }

        public IEnumerable<BlogPostPage> GetAllPosts()
        {
            var posts = new List<BlogPostPage>();

            var postTypes = typeof(BlogHelper).Assembly.GetTypes().Where(w =>
                                                                !w.IsAbstract &&
                                                                w.IsAssignableTo(typeof(BlogPostPage)) &&
                                                                !w.Name.EndsWith("_Imports"));

            foreach (var postType in postTypes)
            {
                var instance = Activator.CreateInstance(postType) as BlogPostPage;
                if (instance == null) continue;
                posts.Add(instance);
            }

            return posts;
        }
    }
}
