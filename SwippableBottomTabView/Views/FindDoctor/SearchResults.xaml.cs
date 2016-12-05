using IFrame.Models;
using IFrame.ViewModels.FindDoctor;
using IFrame.ViewModels.Friends;
using IFrame.Views.Friends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IFrame.Views.FindDoctor
{
	public partial class SearchResults : ContentPage
	{
		public SearchResults ()
		{
		    NavigationPage.SetHasNavigationBar(this, false);
			InitializeComponent ();
		}

	    private void OnFhCicked(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }

	    private void OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
	        var item = (FriendInfo) e.Item;
	        if (item.IsRegister == true)
	        {
	            Navigation.PushAsync(new ResultDetail() { BindingContext = new ResultDetailViewModel(item) });
	        }
            else if (item.IsRegister == false)
            {
                Navigation.PushAsync(new ResultDetailUnreg() { BindingContext = new ResultDetailUnregViewModel(item) });
            }
        }
	}
}
