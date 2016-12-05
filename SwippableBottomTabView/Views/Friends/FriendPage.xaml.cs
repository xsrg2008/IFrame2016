using IFrame.Models;
using IFrame.ViewModels.Friends;
using IFrame.Views.Friends;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IFrame.Views.Friends
{
	public partial class FriendPage : ContentView
	{
		public FriendPage ()
		{
            InitializeComponent();
            BindingContext = new FriendPageViewModel();
        }

	    private void OnAddFriend(object sender, EventArgs e)
	    {
            Navigation.PushAsync(new AddFriendPage());
        }

	    private void OnItemTapped(object sender, ItemTappedEventArgs e)
	    {
            var item = (FriendInfo)e.Item;
            if (item.IsFriendInfo == true)
            {
                Navigation.PushAsync(new FriendDetailPage() { BindingContext = new FriendDetailViewModel(item) });
            }
            else if (item.Name == "添加好友")
            {
                Navigation.PushAsync(new AddFriendPage() { BindingContext = new AddFriendViewModel() });
            }
           
            FriendList.SelectedItem = null;
        }
	}
}
