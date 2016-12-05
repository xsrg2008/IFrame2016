using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace IFrame.ViewModels.Friends
{
    public class FriendDetailViewModel
    {
        public FriendInfo _friendInfo {  set; get; }

        public FriendDetailViewModel(FriendInfo friendinfo)
        {
            _friendInfo = friendinfo;
        }
    }
}
