using Android.OS;
using Android.Runtime;
using MvvmCross.Droid.Support.V7.Preference;
using MvvmCross.Droid.Views.Attributes;
using PreferenceTest.Core.ViewModels;
using PreferenceTest.Core.ViewModels.Fragments;

namespace PreferenceTest.Droid.Fragments
{
    [MvxFragmentPresentation(typeof(MainPreferenceViewModel), Resource.Id.content_frame, true)]
    [Register(nameof(PreferenceFragment))]
    public class PreferenceFragment : MvxPreferenceFragmentCompat<PreferenceViewModel>
    {
        public override void OnCreatePreferences(Bundle savedInstanceState, string rootKey)
        {
            SetPreferencesFromResource(Resource.Xml.preferences, rootKey);
        }
    }
}