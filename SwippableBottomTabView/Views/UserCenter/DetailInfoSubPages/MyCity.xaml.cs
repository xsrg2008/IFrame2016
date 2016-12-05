﻿using IFrame.ViewModels.UserCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.UserCenter
{
    public partial class MyCity : ContentPage
    {
        //string provin;
        public MyCity(string prov)
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = new MyCityViewModel(prov);
            Mylabel.Text = prov;
            //provin = prov;
        }

        private void OnFhCicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void OnCityTapped(object sender, ItemTappedEventArgs e)
        {
            MyCityPlaceViewModel city = (MyCityPlaceViewModel)e.Item;
            //MessagingCenter.Send<MyCity, string>(this, "MYCITY", provin + " "+ city.MyPlace);
            MessagingCenter.Send<MyCity, string>(this, "MYCITY", city.MyPlace);
            MyCityList.SelectedItem = null;
            IReadOnlyList<Page> navStack = Navigation.NavigationStack;
            Navigation.RemovePage(navStack[navStack.Count - 2]);
            Navigation.PopAsync();
        }
    }
}
