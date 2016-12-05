using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.ViewModels.Friends;
using Xamarin.Forms;

namespace IFrame.Views.Friends
{
	public partial class AddFriendPage : ContentPage
	{
		public AddFriendPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}

	    private void OnFhCicked(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }

	    private void OnAddRecommend(object sender, EventArgs e)
	    {
            DisplayAlert("添加医友", "添加推荐医友", "确定");
        }

	    private void OnAddAddressbook(object sender, EventArgs e)
	    {
            Navigation.PushAsync(new AddContants() { BindingContext = new AddContantsViewModel() });
        }

	    private void OnCompleted(object sender, EventArgs e)
	    {
	        Entry entry = (Entry) sender;
            Navigation.PushAsync(new AddResults(entry.Text) { BindingContext = new AddResultsViewModel() });
            //Navigation.PushAsync(new AddNoResults(entry.Text));
        }
	}
}
