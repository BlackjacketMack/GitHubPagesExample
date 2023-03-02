using Microsoft.AspNetCore.Components;

namespace GitHubPagesExample.Pages
{
    public abstract class TechnologyArticle : Article
    {
       public string? Image { get; set; }
       public string? Icon { get; set; }
    }
}
