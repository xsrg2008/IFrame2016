using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.Views.Dialogs;
using Xamarin.Forms;

namespace IFrame.Views.UserCenter
{
	public partial class SetPage : ContentPage
	{
	    private bool HasNewVersin = true;
		public SetPage ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

	    private void OnFhCicked(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }

	    private void OnAlert(object sender, ToggledEventArgs e)
	    {
            DisplayAlert("shengji", "shengji！", "确定");
        }

	    private void OnCleanApp(object sender, EventArgs e)
	    {
            Navigation.PushPopupAsync(new CleanApp());
        }

	    private void OnUpdateApp(object sender, EventArgs e)
	    {
	        if (HasNewVersin == true)
	        {
                Navigation.PushPopupAsync(new NewVersion());
            }
	        else
	        {
                Navigation.PushPopupAsync(new NoUpdate());
            }
        }

	    private void OnAbout(object sender, EventArgs e)
	    {
            Navigation.PushPopupAsync(new AboutApp());
        }

	    private void OnLogout(object sender, EventArgs e)
	    {
            Navigation.PushPopupAsync(new LogoutApp());
        }
	}
}
