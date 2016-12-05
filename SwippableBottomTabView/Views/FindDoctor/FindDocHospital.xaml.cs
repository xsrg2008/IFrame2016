using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.ViewModels.FindDoctor;
using Xamarin.Forms;

namespace IFrame.Views.FindDoctor
{
	public partial class FindDocHospital : ContentPage
	{
		public FindDocHospital ()
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
            HospitalViewModel Hospital = (HospitalViewModel)e.Item;
            MessagingCenter.Send<FindDocHospital, string>(this, "HOSPITAL", Hospital.Hospital);
            HosList.SelectedItem = null;
            Navigation.PopAsync();
        }
    }
}
