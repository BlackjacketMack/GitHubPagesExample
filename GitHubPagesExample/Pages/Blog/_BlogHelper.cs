using GitHubPagesExample.Pages.Blog.Posts;

namespace GitHubPagesExample.Pages.Blog
{
    public class BlogHelper
    {
        public IEnumerable<BlogPostPage> GetRecentPosts()
        {
            var posts = new List<BlogPostPage>();

            var postTypes = typeof(BlogHelper).Assembly.GetTypes().Where(w => !w.IsAbstract && w.IsAssignableFrom(typeof(BlogPostPage)));

           
            foreach(var postType in postTypes)
            {
                var instance = Activator.CreateInstance(postType) as BlogPostPage;
                if (instance == null) continue;
                posts.Add(instance);
            }

            return posts;
        }
    }
}
