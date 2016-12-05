using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.Friends
{
	public partial class AddResults : ContentPage
	{
		public AddResults (string number)
		{
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        private void OnFhCicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

	    private void OnAddRecommend(object sender, EventArgs e)
	    {
	        throw new NotImplementedException();
	    }
	}
}
