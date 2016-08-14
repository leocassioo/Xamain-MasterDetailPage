using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppMasterDetail
{
	public class MenuListData : List<MenuItem>
	{
		public MenuListData()
		{
			this.Add(new MenuItem()
			{
				Titulo = "Inicio",
				TargetType = typeof(Home)
			});

			this.Add(new MenuItem()
			{
				Titulo = "Outra",
				TargetType = typeof(Outra)
			});
		}
	}
}




