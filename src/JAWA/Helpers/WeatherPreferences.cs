using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using WeatherApp;

namespace JAWA
{
	public class WeatherPreferences : IWeatherPreferences {

		private const string PREFERENCES_FILE = "WeatherPreferencesFile";
		private const string PREFS_CITY = "city";
		private Context m_context;

		public WeatherPreferences(Context context)
		{
			m_context = context;
		}

		private ISharedPreferencesEditor OpenSharedPreferencesForEditing(Context context) {
			ISharedPreferences prefs = context.GetSharedPreferences(PREFERENCES_FILE, FileCreationMode.Private);
			return prefs.Edit();
		}

		private ISharedPreferences loadSharedPreferences(Context context) {
			return context.GetSharedPreferences(PREFERENCES_FILE, FileCreationMode.Private);
		}

		public ICollection<string> GetCities() {
			ISharedPreferences prefs = loadSharedPreferences(m_context);
			return prefs.GetStringSet(PREFS_CITY, new List<string>());
		}

		public void SetCities(ICollection<String> cities) {
			var editor = OpenSharedPreferencesForEditing(m_context);
			editor.PutStringSet(PREFS_CITY, cities);
			editor.Apply();
		}

	}
}

