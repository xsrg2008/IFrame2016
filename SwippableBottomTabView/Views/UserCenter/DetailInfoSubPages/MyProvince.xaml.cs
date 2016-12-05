using IFrame.ViewModels.FindDoctor;
using IFrame.ViewModels.UserCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.UserCenter
{
    public partial class MyProvince : ContentPage
    {
        public MyProvince()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            //BindingContext = new MyProvinceViewModel();
        }

        private void OnFhCicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnProvinceTapped(object sender, ItemTappedEventArgs e)
        {
            MyPlaceViewModel prov = (MyPlaceViewModel)e.Item;
            // MessagingCenter.Send<FindDocProvince, string>(this, "PROVINCE", prov.Place);
            MyProList.SelectedItem = null;
            Navigation.PushAsync(new MyCity(prov.MyPlace));
        }
    }
}
