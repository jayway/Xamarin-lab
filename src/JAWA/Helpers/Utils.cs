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

namespace JAWA
{
	public interface ViewHolder {
		ImageView Icon { get; }
		int Position { get; }
	}

	public class JavaObjectWrapper<T> : Java.Lang.Object
	{
		public JavaObjectWrapper (T item) {
			Item = item;
		}

		public override string ToString ()
		{
			return Item.ToString();
		}

		public T Item {get; set;}
	}
}

