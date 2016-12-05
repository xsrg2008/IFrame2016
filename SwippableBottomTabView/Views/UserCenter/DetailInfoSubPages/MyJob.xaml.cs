using IFrame.ViewModels.UserCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.UserCenter
{
    public partial class MyJob : ContentPage
    {
        public MyJob()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void OnFhCicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnJobTapped(object sender, ItemTappedEventArgs e)
        {
            var myjob = (MyJobInfo)e.Item;
            MessagingCenter.Send<MyJob, string>(this, "MYJOB", myjob.MyJob);
            MyJobList.SelectedItem = null;
            Navigation.PopAsync();
        }
    }
}
