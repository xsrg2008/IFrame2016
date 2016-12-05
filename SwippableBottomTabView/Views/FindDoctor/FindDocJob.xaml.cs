using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using IFrame.Models;
using IFrame.ViewModels.FindDoctor;

namespace IFrame.Views.FindDoctor
{
	public partial class FindDocJob : ContentPage
	{
        
        public FindDocJob ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}

	    private void OnFhCicked(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }

	    private void OnJobTapped(object sender, ItemTappedEventArgs e)
	    {
            var job = (JobInfo)e.Item;
            MessagingCenter.Send<FindDocJob, string>(this, "JOB", job.DocJob);
            JobList.SelectedItem = null;
            Navigation.PopAsync();
        }
	}
}
