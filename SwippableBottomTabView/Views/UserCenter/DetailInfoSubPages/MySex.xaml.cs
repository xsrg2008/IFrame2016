using IFrame.ViewModels.UserCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.UserCenter
{
    public partial class MySex : ContentPage
    {
        public MySex()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }
        private void OnFhCicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void OnSexTapped(object sender, ItemTappedEventArgs e)
        {
            var Sex = (MySexViewModelInfo)e.Item;
            MessagingCenter.Send<MySex, string>(this, "MYSEX", Sex.MySex);
            MySexList.SelectedItem = null;
            Navigation.PopAsync();
        }
    }
}
