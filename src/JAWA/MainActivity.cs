using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using WeatherApp.Shared.Repo;

namespace JAWA
{
	[Activity (Label = "JAWA", MainLauncher = true)]
	public class MainActivity : Activity, WeatherRepo.WeatherRepoListener
	{

		private ListView mListView;
		private WeatherRepo mWeatherRepo;


		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
			SetContentView (Resource.Layout.main);
			mListView = FindViewById<ListView> (Resource.Id.listview);

			var inflater = (LayoutInflater)GetSystemService (Context.LayoutInflaterService);
			var header = inflater.Inflate (Resource.Layout.header_bg, null);

			mWeatherRepo = WeatherApplication.Instance.GetWeatherRepo();

			mListView.AddHeaderView (header);

//			mListView.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => {
//				var adapter = mListView.Adapter;
//				var loc = ((JavaObjectWrapper<WeatherLocation>)adapter.GetItem(e.Position)).Item;
//				if (loc != null) {
//					var intent = new Intent(this, typeof(DetailActivity));
//					var bundle = new Bundle();
//					bundle.PutInt(DetailActivity.LOC_ID, loc.Id);
//					intent.PutExtras(bundle);
//					StartActivity(intent);
//				}
//
//			};

		}

		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			this.MenuInflater.Inflate (Resource.Menu.main_activity_option_menu, menu);
			return true;
		}

		protected override void OnResume ()
		{
			base.OnResume ();
			mWeatherRepo.AddListener(this);		
		}

		protected override void OnPause ()
		{
			mWeatherRepo.RemoveListener(this);
			base.OnPause ();
		}

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			switch (item.ItemId) {
			case Resource.Id.action_search:
				var intent = new Intent (this, typeof(SearchActivity));
				StartActivity (intent);
				break;
			}

			return true;
		}


		public void RepoUpdated()
		{
			var adapter = new MainWeatherAdapter (this, mWeatherRepo.GetAllLocations());
			mListView.Adapter = adapter;
		}


	}
}


