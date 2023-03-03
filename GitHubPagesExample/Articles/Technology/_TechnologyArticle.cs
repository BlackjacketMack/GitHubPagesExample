using Microsoft.AspNetCore.Components;

namespace GitHubPagesExample.Pages
{
    public abstract class TechnologyArticle : Article, 
                                            IArticleIcon, 
                                            IArticleImage
    {
       public string? Image { get; set; }
       public string? Icon { get; set; }
       public string? ProjectUrl{get; set;}

        //e.g. NuGet
       public string? PackageUrl{get; set;}

        // GitHub
       public string? SourceUrl{get; set;}
    }
}
