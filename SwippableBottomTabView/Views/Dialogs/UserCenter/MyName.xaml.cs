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
    public partial class MyName : PopupPage
    {
        public MyName(string name)
        {
            InitializeComponent();
            MyNameInput.Text = name;

        }
        private void OnCancleButton(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
            // Navigation.PushPopupAsync(new UpdateApp());
        }

        private void OnConfirmButton(object sender, EventArgs e)
        {
            MessagingCenter.Send<MyName, string>(this, "MYNAME", MyNameInput.Text);
            Navigation.PopPopupAsync();
        }
    }
}
