using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DrawingTestApp.ViewModel
{
    public class TestViewViewModel : BaseViewModel
    {
        #region ScanBehavior
        public bool isScanning { get; set; }
        public bool isAnalyzing { get; set; }

        public Command<object> resultCommand { get; set; }
        #endregion

        public TestViewViewModel(
            INavigationService navigationService, 
            IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {
            isAnalyzing = false;
            isScanning = true;

            RaisePropertyChanged("isScanning");
            RaisePropertyChanged("isAnalyzing");
        }
    }
}
