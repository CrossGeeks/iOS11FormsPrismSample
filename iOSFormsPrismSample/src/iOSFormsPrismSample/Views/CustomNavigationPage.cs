using System;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
namespace iOSFormsPrismSample.Views
{
    public partial class CustomNavigationPage : Xamarin.Forms.NavigationPage
    {
        public CustomNavigationPage()
        {
            On<iOS>().SetPrefersLargeTitles(true);

            this.BarBackgroundColor = (Color)Application.Current.Resources["Primary"];
            this.BarTextColor = Color.White;
        }
    }
}