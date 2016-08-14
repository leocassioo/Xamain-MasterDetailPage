using System;

using Xamarin.Forms;

namespace AppMasterDetail
{
	public class RootPage : MasterDetailPage
	{

		MenuPage menuPage;

		public RootPage()
		{
			menuPage = new MenuPage();

			menuPage.Menu.ItemSelected +=(sender, e) => NavigateTo(e.SelectedItem as MenuItem);

			Master = menuPage;

			Detail = new NavigationPage(new Home());
		}

		async void NavigateTo(MenuItem menu)
		{
			if (menu == null)
			{
				return;
			}

			Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);

			try
			{
				Detail = new NavigationPage(displayPage);
			}
			catch (Exception ex)
			{
				await App.Current.MainPage.DisplayAlert("Erro", "Erro " + ex.Message, "Ok");
			}

			menuPage.Menu.SelectedItem = null;
			IsPresented = false;
		}
}
}


