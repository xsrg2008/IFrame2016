using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using Xamarin.Forms;

namespace IFrame.Views.Dialogs
{
    public partial class ChangeRelation : PopupPage
    {
        private string _relation ;
        private string _heart ;
        public ChangeRelation(string relation, string heart)
        {
            InitializeComponent();
            _relation = relation;
            _heart = heart;
            RelationEntry.Text = relation;
            HeartLabel.Text = heart;
            MessagingCenter.Subscribe<ChooseHeart, string>(this, "HEART", (sender, arg) =>
            {
                HeartLabel.Text = arg;
                _heart = arg;
            });
        }
    
        private void OnChangeHeart(object sender, EventArgs e)
        {
            Navigation.PushPopupAsync(new ChooseHeart());
        }

        private void OnOkButton(object sender, EventArgs e)
        {
            _relation = RelationEntry.Text;
            MessagingCenter.Unsubscribe<ChooseHeart, string>(this, "HEART");
            MessagingCenter.Send<ChangeRelation, string>(this, "RELATION", _relation);
            MessagingCenter.Send<ChangeRelation, string>(this, "HEART", _heart);
            Navigation.PopPopupAsync();
        }

        private void OnNotButton(object sender, EventArgs e)
        {
            MessagingCenter.Unsubscribe<ChooseHeart, string>(this, "HEART");
            Navigation.PopPopupAsync();
        }
    }
}