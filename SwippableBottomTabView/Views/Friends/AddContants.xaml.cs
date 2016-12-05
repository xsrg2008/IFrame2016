using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.ViewModels.Friends;
using Xamarin.Forms;

namespace IFrame.Views.Friends
{
	public partial class AddContants : ContentPage
	{
        
        public AddContants ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            AddContantsViewModel ViewModel = new AddContantsViewModel();
            ContantList.ItemsSource = ViewModel.contacts;
		}

	    private void OnFhCicked(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }
	}
}
