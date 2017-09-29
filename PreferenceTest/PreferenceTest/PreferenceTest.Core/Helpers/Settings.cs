// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace PreferenceTest.Core.Helpers
{
	/// <summary>
	/// This is the Settings static class that can be used in your Core solution or in any
	/// of your client applications. All settings are laid out the same exact way with getters
	/// and setters. 
	/// </summary>
	public static class Settings
	{
		private static ISettings AppSettings
		{
			get
			{
				return CrossSettings.Current;
			}
		}

		#region Setting Constants

		private const string SettingsKey = "settings_key";
	    private const string VibrationKey = "vibration on";

        private static readonly string SettingsDefault = string.Empty;
        private static readonly bool VibrationDefault = true;

		#endregion


	    public static void SetDefaultSettings()
	    {
	        if (!AppSettings.Contains(SettingsKey))
	        {
	            GeneralSettings = SettingsDefault;
            }
            if (!AppSettings.Contains(VibrationKey))
	        {
	            VibrationSettings = VibrationDefault;
            }
	    }

		public static string GeneralSettings
		{
			get
			{
				return AppSettings.GetValueOrDefault(SettingsKey, SettingsDefault);
			}
			set
			{
				AppSettings.AddOrUpdateValue(SettingsKey, value);
			}
		}

        public static bool VibrationSettings
        {
	        get
	        {
	            return AppSettings.GetValueOrDefault(VibrationKey, VibrationDefault);
	        }
	        set
	        {
	            AppSettings.AddOrUpdateValue(VibrationKey, value);
	        }
	    }

    }
}