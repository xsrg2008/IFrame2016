using IFrame.ViewModels.UserCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.UserCenter
{
    public partial class MyHospital : ContentPage
    {
        public MyHospital()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void OnFhCicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnHospitalTapped(object sender, ItemTappedEventArgs e)
        {
            MyHospitalViewModelinfo Hospital = (MyHospitalViewModelinfo)e.Item;
            MessagingCenter.Send<MyHospital, string>(this, "MYHOSPITAL", Hospital.MyHospital);
            MyHosList.SelectedItem = null;
            Navigation.PopAsync();
        }
    }
}
