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

namespace custom_item
{
	public class adapter_listview : BaseAdapter<cls_libro>
	{

		List<cls_libro> items;
		Activity context;

		public adapter_listview(Activity context, List<cls_libro> items): base()
		{
			this.context = context;
			this.items = items;
		}


		#region implemented abstract members of BaseAdapter
		public override long GetItemId (int position)
		{
			return position;
		}
		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var item = items [position];
			View view = convertView;
			if (view == null)
				view = context.LayoutInflater.Inflate (Resource.Layout.custom_item, null);

			view.FindViewById<TextView> (Resource.Id.txtNombre).Text = item.Name;
			view.FindViewById<TextView> (Resource.Id.txtAuthor).Text = item.Author;
			view.FindViewById<TextView> (Resource.Id.txtPage).Text = item._Pag_leidas.ToString()+" DE "+item.TotalPage.ToString()+" pages";
			view.FindViewById<ProgressBar> (Resource.Id.pbProgres).Max = item.TotalPage;
			view.FindViewById<ProgressBar> (Resource.Id.pbProgres).Progress = item._Pag_leidas;

			int id_img = context.Resources.GetIdentifier("img"+item.IdLibro.ToString(), "drawable", context.PackageName);
			view.FindViewById<ImageView> (Resource.Id.imageView1).SetImageResource (id_img);
			return view;


		}
		public override int Count {
			get {
				return items.Count;
			}
		}
		#endregion
		#region implemented abstract members of BaseAdapter
		public override cls_libro this [int index] {
			get {
				return items [index];
			}
		}
		#endregion
	}
}

