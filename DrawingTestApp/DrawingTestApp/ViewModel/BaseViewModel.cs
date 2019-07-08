using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawingTestApp.ViewModel
{
    public class BaseViewModel : 
        BindableBase, 
        INavigationAware, 
        IConfirmNavigation
    {
        #region Protected Classfields

        protected INavigationService _navigationService { get; }
        protected IPageDialogService _pageDialogService { get; }

        #endregion

        #region Constructor

        /// <summary>
        /// Desc: Constructor with injected Services
        ///       BaseClass for CustomViewModels
        /// Author: hsandberg
        /// Date: 12.03.2019
        /// </summary>
        /// <param name="navigationService">INavigationService</param>
        /// <param name="pageDialogService">IPageDialogService</param>
        public BaseViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
        }

        #endregion

        #region Virtual Public Methods

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatingTo(INavigationParameters parameters)
        {
        }

        public virtual bool CanNavigate(INavigationParameters parameters)
        {
            return true;
        }

        #endregion
    }
}
