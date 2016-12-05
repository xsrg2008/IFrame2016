using IFrame.ViewModels.FindDoctor;
using IFrame.Views.Friends;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.Views.Dialogs;
using Xamarin.Forms;

namespace IFrame.Views.FindDoctor
{
	public partial class FindPage : ContentView
	{
        string _Province;
        string _City;
        string _Hospital;
        string _Profession;
        string _Job;
        public FindPage ()
		{
			InitializeComponent ();
            _Province = "";
            _City = "";
            _Hospital = "";
            _Profession = "";
            _Job = "";
            MessagingCenter.Subscribe<FindDocProvince, string>(this, "PROVINCE", (sender, arg) =>
            {
                _Province = arg;
            });
            MessagingCenter.Subscribe<FindDocCity, string>(this, "CITY", (sender, arg) =>
            {
                _City = arg;
                PlaceLabel.Text = arg;
            });
            MessagingCenter.Subscribe<FindDocHospital, string>(this, "HOSPITAL", (sender, arg) =>
            {
                _Hospital = arg;
                HospitalLabel.Text = arg;
            });
            MessagingCenter.Subscribe<FindDocProfession, string>(this, "PROFESSION", (sender, arg) =>
            {
                _Profession = arg;
                ProfessionLabel.Text = arg;
            });
            MessagingCenter.Subscribe<FindDocJob, string>(this, "JOB", (sender, arg) =>
            {
                _Job = arg;
                JobLabel.Text = arg;
            });
        }

	    private void OnPlaceCell(object sender, EventArgs e)
	    {
            Navigation.PushAsync(new FindDocProvince());
        }

	    private void OnHospitalCell(object sender, EventArgs e)
	    {
	        if (_City == "")
	        {
                Navigation.PushPopupAsync(new ChoosePlaceFirst());
            }
	        else
	        {
	            Navigation.PushAsync(new FindDocHospital() { BindingContext = new FindDocHospitalViewModel(_City) });
	        }
            
        }

	    private void OnProfessionCell(object sender, EventArgs e)
	    {
            Navigation.PushAsync(new FindDocProfession() { BindingContext = new FindDocProfessionViewModel() });
        }

	    private void OnJobCell(object sender, EventArgs e)
	    {
            Navigation.PushAsync(new FindDocJob() { BindingContext = new FindDocJobViewModel() });
        }

	    private void OnSearchButton(object sender, EventArgs e)
	    {
            Navigation.PushAsync(new NoSearchResult());
            Navigation.PushAsync(new SearchResults() { BindingContext = new SearchResultsViewModel() });
            
        }
	}
}
