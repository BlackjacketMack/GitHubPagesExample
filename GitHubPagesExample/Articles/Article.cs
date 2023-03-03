using Microsoft.AspNetCore.Components;

namespace GitHubPagesExample.Pages
{
    public abstract class Article : ComponentBase
    {
        public string? Name { get; set; }

        /// <summary>
        /// A unique key for the article.  For blog posts this is used as the permalink.
        /// </summary>
        public string? Key { get; set; }

        public string? Description { get; set; }

        public DateTime PostDate { get; set; }

        public IList<string> Tags { get; set; } = new List<string>();
    }
}
