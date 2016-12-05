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
    public partial class AboutApp : PopupPage
    {
        private string version = "v1.2";
        public AboutApp()
        {
            InitializeComponent();
            versionLabel.Text = "医连 " + version;
        }


        private void OnButton(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
        }
    }
}
