using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DrawingTestApp.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {
        public Command NextCommand { get; set; }

        public HomePageViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            NextCommand = new Command(Next);
        }

        private async void Next()
        {
            await _navigationService.NavigateAsync("TestView");
        }
    }
}
