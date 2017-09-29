using System.Windows.Input;
using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using PreferenceTest.Core.Handlers;
using PreferenceTest.Core.Helpers;
using PreferenceTest.Core.ViewModels.Fragments;

namespace PreferenceTest.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;
        private readonly INotificationHandler _notificationHandler;

        public ICommand PreferencesCommand => new MvxCommand(ExecutePreferences);
        public ICommand SettingsCommand => new MvxCommand(ExecuteSettingsValue);
        
        string hello = "Hello MvvmCross";
        public string Hello
        {
            get => hello;
            set => SetProperty(ref hello, value);
        }

        public FirstViewModel(IMvxNavigationService navigationService, INotificationHandler notificationHandler)
        {
            _navigationService = navigationService;
            _notificationHandler = notificationHandler;
        }

        private async void ExecutePreferences()
        {
            await _navigationService.Navigate<PreferenceViewModel>();
        }

        private void ExecuteSettingsValue()
        {
            _notificationHandler.ShowToast(Settings.VibrationSettings.ToString());
        }
    }
}
