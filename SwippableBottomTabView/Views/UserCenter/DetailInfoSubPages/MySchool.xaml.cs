using IFrame.ViewModels.UserCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.UserCenter
{
    public partial class MySchool : ContentPage
    {
        private string _arg;
        public MySchool(string city, string arg)
        {
            _arg = arg;
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = new MySchoolViewModel(city);
            Mylabel.Text = city;
        }

        private void OnFhCicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnHospitalTapped(object sender, ItemTappedEventArgs e)
        {
            MySchoolViewModelinfo School = (MySchoolViewModelinfo)e.Item;
            MessagingCenter.Send<MySchool, string>(this, _arg, School.MySchool);
            MySchList.SelectedItem = null;
            IReadOnlyList<Page> navStack = Navigation.NavigationStack;
            Navigation.RemovePage(navStack[navStack.Count - 2]);
            Navigation.RemovePage(navStack[navStack.Count - 2]);
            Navigation.PopAsync();
        }
    }
}
