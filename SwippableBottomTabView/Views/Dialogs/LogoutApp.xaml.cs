using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Support.V7.Widget;
using Xamarin.Forms;

namespace IFrame.Views.Dialogs
{
    public partial class LogoutApp : PopupPage
    {
        public LogoutApp()
        {
            InitializeComponent();
        }


        private void OnLogoutButton(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
        }

        private void OnNotButton(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
        }
    }
}
