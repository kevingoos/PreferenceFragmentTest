using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using PreferenceTest.Core.Handlers;
using PreferenceTest.Core.Helpers;

namespace PreferenceTest.Core.ViewModels
{
    public class MainPreferenceViewModel : MvxViewModel
    {
        private readonly INotificationHandler _notificationHandler;

        public MainPreferenceViewModel(INotificationHandler notificationHandler)
        {
            _notificationHandler = notificationHandler;
            Init();
        }

        public void Init()
        {
            _notificationHandler.ShowToast("Initialize settings...");
            Settings.SetDefaultSettings();
        }
    }
}
