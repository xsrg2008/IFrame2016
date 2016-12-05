using IFrame.ViewModels.UserCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.UserCenter
{
    public partial class MyProfession : ContentPage
    {
        public MyProfession()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void OnFhCicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnProfessionTapped(object sender, ItemTappedEventArgs e)
        {
            var Pro = (MyProfessionViewModelInfo)e.Item;
            MessagingCenter.Send<MyProfession, string>(this, "MYPROFESSION", Pro.MyProfession);
            MyProList.SelectedItem = null;
            Navigation.PopAsync();
        }
    }
}
