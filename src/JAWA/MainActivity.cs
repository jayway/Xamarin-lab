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
	public class MainActivity : Activity//, WeatherRepo.WeatherRepoListener
	{

//		private ListView mListView;
//		private WeatherRepo mWeatherRepo;
//
//		@Override
//		protected void onCreate(Bundle savedInstanceState) {
//			super.onCreate(savedInstanceState);
//			setContentView(R.layout.activity_main);
//			mListView = (ListView) findViewById(R.id.listview);
//
//			LayoutInflater inflater = (LayoutInflater) getSystemService(Context.LAYOUT_INFLATER_SERVICE);
//			View header = inflater.inflate(R.layout.header_bg, null, false);
//
//			WeatherApplication application = (WeatherApplication) getApplication();  // -> WeatherApplication.Instance
//			mWeatherRepo = application.getWeatherRepo();
//
//			mListView.addHeaderView(header);
//		}
//
//		@Override
//		public boolean onCreateOptionsMenu(Menu menu) {
//			MenuInflater inflater = getMenuInflater();
//			inflater.inflate(R.menu.main_activity_option_menu, menu);
//			return true;
//		}

//
//		@Override
//		public boolean onOptionsItemSelected(MenuItem item) {
//			switch (item.getItemId()) {
//			case R.id.action_search:
//				Intent intent = new Intent(this, SearchActivity.class);
//				startActivity(intent);
//				break;
//			default:
//				break;
//			}
//
//			return true;
//		}
//
//
//		@Override
//		protected void onResume() {
//			super.onResume();
//			mWeatherRepo.addListener(this);
//		}
//
//		@Override
//		protected void onPause() {
//			mWeatherRepo.removeListener(this);
//			super.onPause();
//		}
//
//		@Override
//		public void repoUpdated() {
//			final MainWeatherAdapter adapter = new MainWeatherAdapter(MainActivity.this, mWeatherRepo.getAllLocations());
//			mListView.setAdapter(adapter);
//		}

	}
}


