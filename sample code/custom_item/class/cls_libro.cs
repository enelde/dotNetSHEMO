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
	public class cls_libro
	{
		int idLibro;
		string name;
		string author;
		int totalPage;
		int _pag_leidas;

		public cls_libro(	int idLibro,
			string name,
			string author,
			int totalPage,
			int _pag_leidas)
		{
			this.idLibro = idLibro;
				this.name = name;
				this.author = author;
				this.totalPage = totalPage;
				this._pag_leidas = _pag_leidas;
		}

		public int _Pag_leidas
		{
			get
			{
				return _pag_leidas;
			}
			set
			{
				_pag_leidas = value;
			}
		}

		public int TotalPage
		{
			get
			{
				return totalPage;
			}
			set
			{
				totalPage = value;
			}
		}


		public string Author
		{
			get
			{
				return author;
			}
			set
			{
				name = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}

		public int IdLibro
		{
			get
			{
				return idLibro;
			}
			set
			{
				idLibro = value;
			}
		}

	}
}

