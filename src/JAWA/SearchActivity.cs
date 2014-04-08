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
using Android.Text;

using WeatherApp.Shared.Domain;
using WeatherApp.Shared.Server;

namespace JAWA
{
	[Activity (Label = "SearchActivity")]			
	public class SearchActivity : Activity
	{

		private ListView mListView;
		private EditText mEditText;




		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_search);

			mListView = (ListView) FindViewById(Resource.Id.ListView01);
			mListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
				var item =  mListView.Adapter.GetItem(e.Position).JavaCast<JavaObjectWrapper<WeatherLocation>>().Item;
				var weatherRepo = WeatherApplication.Instance.GetWeatherRepo();
				weatherRepo.AddLocation(item);
				Finish();
			};

			mEditText = (EditText) FindViewById(Resource.Id.EditText01);
			mEditText.AddTextChangedListener(new SearchTextListener (mListView, this));

			ActionBar.SetHomeButtonEnabled(true);
			ActionBar.SetDisplayHomeAsUpEnabled (true);
		}


		public override bool OnOptionsItemSelected (IMenuItem menuItem)
		{
			switch (menuItem.ItemId) {
			case Android.Resource.Id.Home:
				Finish();
				return true;
			}
			return base.OnOptionsItemSelected (menuItem);
		} 



		private class SearchTextListener : Java.Lang.Object, ITextWatcher 
		{
			private ListView mListView;
			private Activity mActivity;
			public SearchTextListener(ListView listView, Activity activity)
			{
				mListView = listView;
				mActivity = activity;
			}

			public void AfterTextChanged (IEditable s)
			{
			}

			public void BeforeTextChanged (Java.Lang.ICharSequence s, int start, int count, int after)
			{
			}

			public async void OnTextChanged (Java.Lang.ICharSequence s, int start, int before, int count)
			{
				if (s.Length() > 2) {
					//TODO: Add cancel support
					var api = new OWMApi();
					var result = await api.Search (s.ToString());
					var wrapresult = result.Select ((w) => new JavaObjectWrapper<WeatherLocation>(w)).ToList();

					mListView.Adapter = new ArrayAdapter<JavaObjectWrapper<WeatherLocation>>(mActivity, Android.Resource.Layout.SimpleListItem1, wrapresult);
				}

			}
		}
	}
}

