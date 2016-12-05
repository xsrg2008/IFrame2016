using IFrame.Models;
using IFrame.Views;
using IFrame.Views.Cells;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace IFrame.Controls
{
    public class FriendCellTemplateSelector : DataTemplateSelector
    {
        public FriendCellTemplateSelector()
        {
            // Retain instances!
            this.friendListTemplate = new DataTemplate(typeof(FriendListCell));
            this.friendOtherTemplate = new DataTemplate(typeof(FriendOtherCell));
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var friendInfo = item as FriendInfo;
            if (friendInfo == null)
                return null;
            return friendInfo.IsFriendInfo ? this.friendListTemplate : this.friendOtherTemplate;
        }

        private readonly DataTemplate friendListTemplate;
        private readonly DataTemplate friendOtherTemplate;
    }
}
