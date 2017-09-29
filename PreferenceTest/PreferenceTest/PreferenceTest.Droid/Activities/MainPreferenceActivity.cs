using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using PreferenceTest.Core.ViewModels;

namespace PreferenceTest.Droid.Activities
{
    [Activity(Label = "Settings"), IntentFilter(new []{ "android.intent.action.MANAGE_NETWORK_USAGE" }, Categories = new []{ "android.intent.category.DEFAULT" })]
    public class MainPreferenceActivity : MvxAppCompatActivity<MainPreferenceViewModel>
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MainPreferenceView);
        }
    }
}