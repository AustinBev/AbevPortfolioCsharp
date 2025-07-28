using Microsoft.AspNetCore.Components;

namespace AbevPortfolioCsharp.pages
{
    public partial class Home : ComponentBase
    {
        protected string PixelImage = "/images/PixelAustin.png";
        protected string RealImage = "/images/ABEV2.jpg";
        protected string CurrentImage;

        protected override void OnInitialized()
        {
            CurrentImage = PixelImage;
        }

        protected void ToggleHeadshot()
        {
            CurrentImage = CurrentImage == PixelImage ? RealImage : PixelImage;
        }
    }
}
