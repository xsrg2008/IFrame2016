using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.ViewModels.FindDoctor;
using Xamarin.Forms;

namespace IFrame.Views.FindDoctor
{
	public partial class FindDocProfession : ContentPage
	{
		public FindDocProfession ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}

	    private void OnFhCicked(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }

	    private void OnProfessionTapped(object sender, ItemTappedEventArgs e)
	    {
            var Pro = (ProfessionViewModel)e.Item;
            MessagingCenter.Send<FindDocProfession, string>(this, "PROFESSION", Pro.Profession);
            ProList.SelectedItem = null;
            Navigation.PopAsync();
        }
	}
}
