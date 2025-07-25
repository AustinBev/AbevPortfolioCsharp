using Microsoft.AspNetCore.Components;


namespace AbevPortfolioCsharp.Layout
{
    public partial class MainLayout : LayoutComponentBase
    {
        private bool IsDarkMode = true;

        private void SetTheme(string theme)
        {
            IsDarkMode = theme == "dark";
        }
    }
}
