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
	public class MainWeatherAdapter// : BaseAdapter //XAMARIN: Do uncomment and implement BaseAdapter
	{
//		private static final int IN_SAMPLE_SIZE = 7;
//
//		private final Context mContext;
//		private List<WeatherLocation> mAllLocations;
//		//XAMARIN: You may have to use List<JavaObjectWrapper<WeatherLocation>>
//
//		public MainWeatherAdapter(Context context, List<WeatherLocation> allLocations) {
//			mContext = context;
//			mAllLocations = allLocations;
//		//XAMARIN: allLocations.Select(o => new JavaObjectWrapper<WeatherLocation>(o)).ToList();
//
//			BitmapFactory.Options bmpFactoryOptions = new BitmapFactory.Options();
//			bmpFactoryOptions.inSampleSize = IN_SAMPLE_SIZE;
//			bmpFactoryOptions.inJustDecodeBounds = false;
//		}
//
//		@Override
//		public int getCount() {
//			return mAllLocations.size();
//		}
//
//		@Override
//		public View getView(int position, View convertView, ViewGroup parent) {
//			final MainWeatherViewHolder holder;
//			if (convertView == null) {
//				LayoutInflater inflater = (LayoutInflater) mContext.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
//				convertView = inflater.inflate(R.layout.item_weather, parent, false);
//
//				holder = new MainWeatherViewHolder();
//				holder.city = (TextView) convertView.findViewById(R.id.city_name);
//				holder.country = (TextView) convertView.findViewById(R.id.country);
//				holder.temperature = (TextView) convertView.findViewById(R.id.temperature);
//				holder.metaData = (TextView) convertView.findViewById(R.id.metadata);
//				holder.setIcon((ImageView) convertView.findViewById(R.id.weather_icon));
//
//				convertView.setTag(holder);
//			} else {
//				holder = (MainWeatherViewHolder) convertView.getTag();
//			}
//
//			holder.setPosition(position);
//
//			WeatherLocation location = (WeatherLocation) getItem(position);
//		//XAMARIN: ((JavaObjectWrapper<WeatherLocation>)GetItem(position)).Item;
//
//			holder.city.setText(location.getName());
//			holder.country.setText(location.getCountry());
//
//			String temp = String.format(mContext.getString(R.string.temperature_in_celcius, location.getTemperature()));
//		//XAMARIN: var temp = String.Format("{0} °C", location.Temperature.ToString());;
//			holder.temperature.setText(String.format(temp));
//			holder.metaData.setText(location.getDescription());
//			holder.icon.setImageResource(location.getIcon());
//		//XAMARIN: holder.Icon.SetImageResource(IconConverter.WeatherIdToIconId(location.Icon));
//
//			return convertView;
//		}
//
//
//		public static class MainWeatherViewHolder implements ViewHolder {
//		// XAMARIN: In c# you have to make MainWeatherViewHolder inherit Java.Lang.Object
//			TextView city;
//			TextView country;
//			TextView temperature;
//
//			TextView metaData;
//			private ImageView icon;
//
//			private int position;
//
//			public int getPosition() {
//				return position;
//			}
//
//			public void setPosition(int position) {
//				this.position = position;
//			}
//
//			public ImageView getIcon() {
//				return icon;
//			}
//
//			public void setIcon(ImageView icon) {
//				this.icon = icon;
//			}
//		}
//
//		@Override
//		public Object getItem(int position) {
//			return mAllLocations.get(position);
//		}
//
//		@Override
//		public long getItemId(int position) {
//			return position;
//		}

	}
}

