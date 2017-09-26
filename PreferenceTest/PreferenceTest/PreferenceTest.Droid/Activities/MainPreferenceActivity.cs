using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using PreferenceTest.Core.ViewModels;

namespace PreferenceTest.Droid.Activities
{
    [Activity(Label = "Settings")]
    public class MainPreferenceActivity : MvxAppCompatActivity<MainPreferenceViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainPreferenceView);
        }
    }
}