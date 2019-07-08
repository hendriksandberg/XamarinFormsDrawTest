using System.Reflection;
using DrawingTestApp.ViewModel;
using DrawingTestApp.Views;
using Prism;
using Prism.Ioc;
using Prism.Unity;

using Xamarin.Forms;

namespace DrawingTestApp
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer)
        {
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // TODO Worklfow on sleep WiP
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("HomePage");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // View Registration

            /* Base Pages */
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomePageViewModel>();
            containerRegistry.RegisterForNavigation<TestView, TestViewViewModel>();
        }
    }
}
