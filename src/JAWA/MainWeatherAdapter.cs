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
using Android.Graphics;

using WeatherApp.Shared.Domain;

namespace JAWA
{
	public class MainWeatherAdapter : BaseAdapter 
	{

		private const int IN_SAMPLE_SIZE = 7;

		private readonly Context mContext;
		private List<JavaObjectWrapper<WeatherLocation>> mAllLocations;

		public MainWeatherAdapter(Context context, List<WeatherLocation> allLocations) {
			mContext = context;
			mAllLocations = allLocations.Select(o => new JavaObjectWrapper<WeatherLocation>(o)).ToList();

			BitmapFactory.Options bmpFactoryOptions = new BitmapFactory.Options();
			bmpFactoryOptions.InSampleSize = IN_SAMPLE_SIZE;
			bmpFactoryOptions.InJustDecodeBounds = false;
		}

		public override int Count {
			get {
				return mAllLocations.Count;
			}
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			MainWeatherViewHolder holder;
			if (convertView == null) {
				LayoutInflater inflater = (LayoutInflater) mContext.GetSystemService(Context.LayoutInflaterService);
				convertView = inflater.Inflate(Resource.Layout.item_weather, parent, false);

				holder = new MainWeatherViewHolder();
				holder.city = (TextView) convertView.FindViewById(Resource.Id.city_name);
				holder.country = (TextView) convertView.FindViewById(Resource.Id.country);
				holder.temperature = (TextView) convertView.FindViewById(Resource.Id.temperature);
				holder.metaData = (TextView) convertView.FindViewById(Resource.Id.metadata);
				holder.Icon = (ImageView) convertView.FindViewById(Resource.Id.weather_icon);

				convertView.Tag = holder;
			} else {
				holder = (MainWeatherViewHolder) convertView.Tag;
			}

			holder.Position = position;

			WeatherLocation location = ((JavaObjectWrapper<WeatherLocation>)GetItem(position)).Item;

			holder.city.Text = location.Name;
			holder.country.Text = location.Country;
			var temp = String.Format("{0} °C", location.Temperature.ToString());;
			holder.temperature.Text = temp;
			holder.metaData.Text = location.Description;
			holder.Icon.SetImageResource(IconConverter.WeatherIdToIconId(location.Icon));

			return convertView;
		}

		public class MainWeatherViewHolder : Java.Lang.Object, ViewHolder  {
			public TextView city;
			public TextView country;
			public TextView temperature;

			public TextView metaData;
			public ImageView Icon { get; set; }

			public int Position { get; set; }

		}

		public override Java.Lang.Object GetItem (int position)
		{
			return mAllLocations [position];
		}
		public override long GetItemId (int position)
		{
			return position;
		}

	}
}

