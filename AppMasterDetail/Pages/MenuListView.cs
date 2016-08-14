﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppMasterDetail
{
	public class MenuListView : ListView
	{
		public MenuListView()
		{
			List<MenuItem> data = new MenuListData();

			ItemsSource = data;
			VerticalOptions = LayoutOptions.FillAndExpand;
			BackgroundColor = Color.Transparent;

			var cell = new DataTemplate(typeof(MenuCell));
			cell.SetBinding(MenuCell.TextProperty, "Titulo");

			ItemTemplate = cell;
			
		}
	}
}


