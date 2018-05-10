using System;
using Prism.Commands;
using Prism.Navigation;

namespace iOSFormsPrismSample.ViewModels
{
    public class MainPageViewModel
    {
        public DelegateCommand NavigateToDetailCommand { get; set; }
        public MainPageViewModel(INavigationService navigationService)
        {
            NavigateToDetailCommand = new DelegateCommand(async() => await navigationService.NavigateAsync("DetailPage"));
        }
    }
}
