using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAWA
{
	public class IconConverter
	{

		public static int WeatherIdToIconId(int weatherId)
		{
			if (weatherId >= 200 && weatherId <= 231)
				return Resource.Drawable.weathericons_0014_15;
			if (weatherId >= 500 && weatherId <= 504)
				return Resource.Drawable.weathericons_0013_14;
			if (weatherId == 511)
				return Resource.Drawable.weathericons_0009_10;
			if (weatherId >= 520 && weatherId <= 522)
				return Resource.Drawable.weathericons_0012_13;
			if (weatherId == 600)
				return Resource.Drawable.weathericons_0009_10;
			if (weatherId >= 601 && weatherId <= 621)
				return Resource.Drawable.weathericons_0008_09;
			if (weatherId >= 701 && weatherId < 741)
				return Resource.Drawable.weathericons_0011_12;
			if (weatherId == 800)
				return Resource.Drawable.weathericons_0019_20;
			if (weatherId >= 801 && weatherId <= 802)
				return Resource.Drawable.weathericons_0017_18;
			if (weatherId >= 803 && weatherId <= 804)
				return Resource.Drawable.weathericons_0015_16;
			return Resource.Drawable.weathericons_0019_20;
		}

	}
}
