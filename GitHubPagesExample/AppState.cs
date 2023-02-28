using GitHubPagesExample.Pages.Blog.Posts;

namespace GitHubPagesExample
{
    public class AppState
    {
        public bool IsDarkMode;
        public MudBlazor.Color AppBarColor => IsDarkMode ? MudBlazor.Color.Default : MudBlazor.Color.Primary;

        public event Action StateChanged;
        public void NotifyStateChanged() => StateChanged?.Invoke();
    }
}
