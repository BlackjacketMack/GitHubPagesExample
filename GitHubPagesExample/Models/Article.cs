using Microsoft.AspNetCore.Components;

namespace GitHubPagesExample.Pages
{
    public abstract class Article : ComponentBase
    {
        public string? Name { get; set; }
        public string? Permalink { get; set; }

        public DateTime PostDate { get; set; }
    }
}
