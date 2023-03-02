using Microsoft.AspNetCore.Components;

namespace GitHubPagesExample.Pages
{
    public abstract class BlogArticle : Article
    {
        public string? PermaLink => $"blog/{Key}";
    }
}
