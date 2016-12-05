using IFrame.ViewModels.FindDoctor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.FindDoctor
{
	public partial class FindDocCity : ContentPage
	{
		public FindDocCity (string prov)
		{
            NavigationPage.SetHasNavigationBar(this, false);
		    InitializeComponent();
		    BindingContext = new FindDocCityViewModel(prov);
		    label.Text = prov;
		}

	    private void OnFhCicked(object sender, EventArgs e)
	    {
	        Navigation.PopAsync();
	    }

	    private void OnProvinceTapped(object sender, ItemTappedEventArgs e)
	    {
            PlaceViewModel city = (PlaceViewModel)e.Item;
            MessagingCenter.Send<FindDocCity,string>(this,"CITY",city.Place);
	        CityList.SelectedItem = null;
	        IReadOnlyList<Page> navStack = Navigation.NavigationStack;
	        Navigation.RemovePage(navStack[navStack.Count - 2]);
	        Navigation.PopAsync();
	    }
	}
}
