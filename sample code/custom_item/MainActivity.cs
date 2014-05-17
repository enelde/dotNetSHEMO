using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;


namespace custom_item
{
	[Activity (Label = "custom_item", MainLauncher = true)]
	public class MainActivity : Activity
	{
		List<cls_libro> libros = new List<cls_libro> ();

//		cls_libro asd = new cls_libro(1,"FROZEN THRONE", "NAFI",120,10);
//
		

		void OnListItemClick (object sender, AdapterView.ItemClickEventArgs e)
		{
			var listView = sender as ListView;
			var l = libros [e.Position];
			Android.Widget.Toast.MakeText (this, l.Name, Android.Widget.ToastLength.Short).Show();
			//Android.Widget.Toast.MakeText(this, l
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Main);

			libros.Add(new cls_libro(1,"FROZEN THRONE", "NAFI",120,10));
			libros.Add(new cls_libro(2,"FROZEN THRONE 2", "NAFI",120,10));
			libros.Add(new cls_libro(3,"FROZEN THRONE 3", "NAFI",120,10));
			libros.Add(new cls_libro(4,"FROZEN THRONE 4", "NAFI",120,10));

					
			ListView lvLibros = FindViewById<ListView> (Resource.Id.lvLibros);

			lvLibros.Adapter = new adapter_listview (this, libros);

			lvLibros.ItemClick += OnListItemClick;

		}


	}
}


