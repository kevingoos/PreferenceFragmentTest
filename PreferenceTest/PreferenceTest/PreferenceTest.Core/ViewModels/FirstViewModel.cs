using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using PreferenceTest.Core.ViewModels.Fragments;

namespace PreferenceTest.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public ICommand PreferencesCommand => new MvxCommand(ExecutePreferences);
        
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get => hello;
            set => SetProperty(ref hello, value);
        }

        public FirstViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        private async void ExecutePreferences()
        {
            await _navigationService.Navigate<PreferenceViewModel>();
        }
    }
}
