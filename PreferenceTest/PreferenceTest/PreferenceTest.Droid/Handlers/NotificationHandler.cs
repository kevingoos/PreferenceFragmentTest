using Android.Support.Design.Widget;
using Android.Widget;
using MvvmCross.Platform;
using MvvmCross.Platform.Droid.Platform;
using PreferenceTest.Core.Handlers;

namespace PreferenceTest.Droid.Handlers
{
    public class NotificationHandler : INotificationHandler
    {
        public void ShowSnackbar(string message)
        {
            var currentActivity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>();
            var activityRootView = currentActivity.Activity.FindViewById(Android.Resource.Id.Content);

            currentActivity.Activity.RunOnUiThread(() =>
            {
                Snackbar.Make(activityRootView, message, Snackbar.LengthLong).Show();
            });
        }

        public void ShowToast(string message)
        {
            var currentActivity = Mvx.Resolve<IMvxAndroidCurrentTopActivity>();
            currentActivity.Activity.RunOnUiThread(() =>
            {
                Toast.MakeText(currentActivity.Activity, message, ToastLength.Long).Show();
            });
        }
    }
}