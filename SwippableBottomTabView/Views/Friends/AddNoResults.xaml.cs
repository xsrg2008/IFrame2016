using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace IFrame.Views.Friends
{
	public partial class AddNoResults : ContentPage
	{
        class Number
        {
            public string number { get; set; }

            public Number(string i)
            {
                number = i;
            }
        };

        public AddNoResults(string num)
	    {
	        {
	            NavigationPage.SetHasNavigationBar(this, false);
	            InitializeComponent();
                List<Number> Items = new List<Number>
            {
                new Number(num),
            };
                ResultList.ItemsSource = Items;
            }
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
