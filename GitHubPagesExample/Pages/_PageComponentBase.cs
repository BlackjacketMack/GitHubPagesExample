using Microsoft.AspNetCore.Components;

namespace GitHubPagesExample.Pages
{
    public abstract class PageComponentBase : ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; } = default!;

        public void NavigateTo(string url) => NavigationManager.NavigateTo(url);
    }
}
