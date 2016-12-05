using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.FindDoctor
{
	public partial class ResultDetail : ContentPage
	{
		public ResultDetail ()
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent ();
		}

	    private void OnFhButton(object sender, EventArgs e)
	    {
            Navigation.PopAsync();
        }
	}
}
