using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.FindDoctor
{
	public partial class NoSearchResult : ContentPage
	{
		public NoSearchResult ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}

	    private void OnFhCicked(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }
	}
}
