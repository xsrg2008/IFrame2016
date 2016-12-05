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
    public partial class MyInterest : PopupPage
    {
        public MyInterest(string interest)
        {

            InitializeComponent();
            MyInterestInput.Text = interest;

        }

        private void OnCancleButton(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
            // Navigation.PushPopupAsync(new UpdateApp());
        }

        private void OnConfirmButton(object sender, EventArgs e)
        {
            MessagingCenter.Send<MyInterest, string>(this, "MYINTEREST", MyInterestInput.Text);
            Navigation.PopPopupAsync();
        }
    }
}
