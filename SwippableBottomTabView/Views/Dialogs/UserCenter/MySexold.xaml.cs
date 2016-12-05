using IFrame.ViewModels.UserCenter;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.Dialogs.UserCenter
{
    public partial class MySexold : PopupPage
    {
        public MySexold()
        {
            InitializeComponent();
        }
        private void OnSexTapped(object sender, ItemTappedEventArgs e)
        {
            var mysex = (MySexViewModelInfo)e.Item;
            MessagingCenter.Send<MySexold, string>(this, "MYSEXOLD", mysex.MySex);
            MySexList.SelectedItem = null;
            Navigation.PopPopupAsync();
        }

    }
}
