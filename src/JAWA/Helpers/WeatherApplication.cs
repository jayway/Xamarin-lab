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

using WeatherApp.Shared.Repo;

namespace JAWA
{
	public class WeatherApplication
	{
		private WeatherRepo _weatherRepo;

		public WeatherRepo GetWeatherRepo()
		{
			if (_weatherRepo == null) 
			{
				_weatherRepo = new WeatherRepo(new WeatherPreferences(Android.App.Application.Context));
				_weatherRepo.Init();
			}
			return _weatherRepo;
		}


		private WeatherApplication()
		{
		}

		private static WeatherApplication _intance;

		public static WeatherApplication Instance
		{
			get
			{
				if (_intance == null)
					_intance = new WeatherApplication();
				return _intance; 
			}
		}
	}
}

