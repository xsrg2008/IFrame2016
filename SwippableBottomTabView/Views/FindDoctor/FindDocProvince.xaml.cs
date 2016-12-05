using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.ViewModels.FindDoctor;
using Xamarin.Forms;

namespace IFrame.Views.FindDoctor
{
	public partial class FindDocProvince : ContentPage
	{
		public FindDocProvince ()
		{
		    NavigationPage.SetHasNavigationBar(this, false);
		    InitializeComponent ();
		    BindingContext = new FindDocProvinceViewModel();
		}

	    private void OnFhCicked(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }

	    private void OnProvinceTapped(object sender, ItemTappedEventArgs e)
	    {
	        PlaceViewModel prov = (PlaceViewModel) e.Item;
            MessagingCenter.Send<FindDocProvince, string>(this, "PROVINCE", prov.Place);
	        ProList.SelectedItem = null;
	        Navigation.PushAsync(new FindDocCity(prov.Place));
	    }
	}
}
