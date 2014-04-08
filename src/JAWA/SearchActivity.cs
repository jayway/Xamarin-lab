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

//		private ListView mListView;
//		private EditText mEditText;
//
//		public void onCreate(Bundle savedInstanceState) {
//			super.onCreate(savedInstanceState);
//			setContentView(R.layout.activity_search);
//
//			mListView = (ListView) findViewById(R.id.ListView01);
//			mListView.setOnItemClickListener(new OnItemClickListener() {
//				@Override
//				public void onItemClick(AdapterView<?> list, View itemView,
//					int position, long id) {
//					WeatherLocation item = (WeatherLocation) mListView.getAdapter()
//						.getItem(position);   
//					WeatherApplication application = (WeatherApplication) getApplication();
//					WeatherRepo weatherRepo = application.getWeatherRepo();
//					weatherRepo.addLocation(item);
//					finish();
//				}
//			});
//
//			mEditText = (EditText) findViewById(R.id.EditText01);
//			mEditText.addTextChangedListener(new SearchTextListener());
//
//			getActionBar().setHomeButtonEnabled(true);
//			getActionBar().setDisplayHomeAsUpEnabled(true);
//		}
//
//		@Override
//		public boolean onOptionsItemSelected(MenuItem menuItem) {
//			switch (menuItem.getItemId()) {
//			case android.R.id.home:
//				finish();
//				return true;
//			}
//			return (super.onOptionsItemSelected(menuItem));
//		}
//
//		private class SearchTextListener implements TextWatcher {
//		// XAMARIN: In c# you have to make SearchTextListener inherit Java.Lang.Object
//		// XAMARIN: inner classes in java can access outer classes private members, i C# you have add the ListView and SearchActivity in e.g the contructor of SearchTextListener 
//
//
//			SearchLocation prevLocation;
//
//			@Override
//			public void afterTextChanged(Editable s) {
//			}
//
//			@Override
//			public void beforeTextChanged(CharSequence s, int start, int count,
//				int after) {
//			}
//
//			@Override
//			public void onTextChanged(CharSequence s, int start, int before,
//				int count) {
//				if (s.length() > 2) {
//		//XAMARIN: skip the cancel functionality if you want, its ok to use a simple await and skip a helper class like SearchLocation
		//         just look at the code in doInBackground & onPostExecute in the SearchLocation AsyncTask 

//					if (prevLocation != null)
//						prevLocation.cancel(true);
//					prevLocation = new SearchLocation(SearchActivity.this,
//						mListView);
//					prevLocation.execute(s.toString());
//				}
//
//			}
//
//		}
//		public class SearchLocation extends AsyncTask<String, Void, ArrayList<WeatherLocation>> {
//
//			private ListView mListView;
//
//			private Activity mActivity;
//
//			public SearchLocation(Activity activity, ListView listView) {
//				this.mActivity = activity;
//				this.mListView = listView;
//			}
//
//			@Override
//			protected ArrayList<WeatherLocation> doInBackground(String... params) {
//				OWMApi api = new OWMApi();
//				ArrayList<WeatherLocation> result = api.search(params[0]);
//
//				return result;
//			}
//
//			@Override
//			protected void onPostExecute(ArrayList<WeatherLocation> result) {
//		//XAMARIN: you may have to use the JavaObjectWrapper
//		//         var wrapresult = result.Select ((w) => new JavaObjectWrapper<WeatherLocation>(w)).ToList();
//
//				mListView.setAdapter(new ArrayAdapter<WeatherLocation>(mActivity,
//					android.R.layout.simple_list_item_1, result));
//			}
//		}
	}
}

