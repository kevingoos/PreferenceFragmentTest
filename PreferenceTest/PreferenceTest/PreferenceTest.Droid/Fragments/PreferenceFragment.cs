using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Droid.Views.Attributes;
using MvvmCross.Droid.Views.Fragments;
using PreferenceTest.Core.ViewModels;
using PreferenceTest.Core.ViewModels.Fragments;
using PreferenceTest.Droid.Activities;

namespace PreferenceTest.Droid.Fragments
{
    [MvxFragmentPresentation(typeof(MainPreferenceViewModel), Resource.Id.content_frame, true)]
    [Register(nameof(PreferenceFragment))]
    public class PreferenceFragment : MvxPreferenceFragment<PreferenceViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
            var view = this.BindingInflate(Resource.Xml.preferences, container, false);
            return view;
        }
    }
}