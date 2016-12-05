using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Support.V7.Widget;
using Xamarin.Forms;

namespace IFrame.Views.Dialogs
{
    public partial class ChooseHeart : PopupPage
    {
        class HeartItem
        {
            public string heartItem { get; set; }

            public HeartItem(string i)
            {
                heartItem = i;
            }
        };

        public ChooseHeart()
        {
            InitializeComponent();

            List<HeartItem> Items = new List<HeartItem>
            {
                new HeartItem("黑名单"),
                new HeartItem("一般"),
                new HeartItem("较熟"),
                new HeartItem("特熟")
            };
            listView.ItemsSource = Items;
        }

        private void OnOkButton(object sender, EventArgs e)
        {
            HeartItem heart = (HeartItem) listView.SelectedItem;
            MessagingCenter.Send<ChooseHeart, string>(this, "HEART", heart.heartItem);
            Navigation.PopPopupAsync();
        }

        private void OnNotButton(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
        }
    }
}

