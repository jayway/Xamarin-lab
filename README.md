Xamarin-lab
===========

1. Create a new Android project in either Visual Studio or Xamarin Studio
2. Remove the Main.axml file from Resources/layout
3. Open "MainActivity.cs" and update the code to the following:
	```C#
	public class MainActivity : Activity
	{
		int count = 1;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			var btn = new Button (this) 
			{ 
				Text = "Hello Xamarin!"
			};
			SetContentView (btn);
			btn.Click += delegate {
				btn.Text = string.Format ("{0} clicks!", count++);
			};
		}
	} 	
	```


4. Compile and run the code on either a device or an emulator

5. Try to understand everything, make some explorational changes to the code and have a quick glance at the documentation links at the end

6. (Re)create Main.axml in Resources/layout with the following content
	```XML
	<?xml version="1.0" encoding="utf-8"?>
	<LinearLayout xmlns:android="http://schemas.android.com/apk/res/android"
	    android:orientation="vertical"
	    android:layout_width="fill_parent"
	    android:layout_height="fill_parent">
	<Button
	    android:id="@+id/myButton"
	    android:layout_width="fill_parent"
	    android:layout_height="wrap_content"
	    android:text="Hello axml!" />
	</LinearLayout>
	
	```

7. Replace the creation of the button and the call to SetContentView with the following:
	```C#
	SetContentView (Resource.Layout.Main);
	var btn = FindViewById<Button>(Resource.Id.myButton);
	```

8. Add a second button with some other logic and/or make some other explorational changes to the code

9. Open the JAWA (Just-Another-Weather-App) solution in Visual Studio or Xamarin Studio

10. Start with MainActivity.cs and translate all methods except onResume, onPause & repoUpdated from Java to Xamarin C#

11. Continue with SearchActivity.cs

12. Finish with MainWeatherAdapter.cs and the rest of MainActivity.cs


Links
=====
- [Android API - Xamarin](http://androidapi.xamarin.com/?link=root:/MonoAndroid-lib)
-  [Xamarin.Android Guides & Tutorials](http://docs.xamarin.com/guides/android/)
-  [Xamarin docs](http://docs.xamarin.com/)


