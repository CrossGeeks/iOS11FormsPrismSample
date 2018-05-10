using System.Threading.Tasks;
using iOSFormsPrismSample.Views;
using Prism;
using Prism.Ioc;
using Unity;
using Prism.Unity;
using Prism.Logging;
using Xamarin.Forms;

namespace iOSFormsPrismSample
{
    public partial class App : PrismApplication
    {
        public App() : this(null){}

        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            await NavigationService.NavigateAsync("CustomNavigationPage/MainPage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<CustomNavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<DetailPage>();
        }

    }
}
