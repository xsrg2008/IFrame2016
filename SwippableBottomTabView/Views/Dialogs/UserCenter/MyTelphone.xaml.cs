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
    public partial class MyTelphone : PopupPage
    {
        public MyTelphone(string telphone)
        {
            InitializeComponent();
            MyTelphoneInput.Text = telphone;
        }

        private void OnCancleButton(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
            // Navigation.PushPopupAsync(new UpdateApp());
        }

        private void OnConfirmButton(object sender, EventArgs e)
        {
            MessagingCenter.Send<MyTelphone, string>(this, "MYTELPHONE", MyTelphoneInput.Text);
            Navigation.PopPopupAsync();
        }
    }
}
