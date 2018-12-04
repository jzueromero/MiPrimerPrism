using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiPrimerPrism.ViewModels
{
    
    public class HomePageViewModel
    {
        INavigationService _navigationService;
        public HomePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

    }
}
