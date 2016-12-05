using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.FindDoctor
{
    public class ResultDetailUnregViewModel
    {
        public FriendInfo _friendInfo { set; get; }

        public ObservableCollection<FriendInfo> _searchResult { set; get; }


        public ResultDetailUnregViewModel(FriendInfo friendinfo)
        {
            _friendInfo = friendinfo;

            _searchResult = new ObservableCollection<FriendInfo>();
            _searchResult.Add(new FriendInfo()
            {
                Name = "刘医生",
                Hospital = "北医三院",
                Profession = "皮肤科",
                Job = "主任医师",
                FriendPhoto = "@drawable/doctor",
                Age = "45",
                Gender = "male",
                Heart = "一般",
                Relationship = "老师",
                Goodat = "瘙痒，过敏",
                PhoneNumber = "12345678901",
                IsFriendInfo = true
            });
        }
    }
}
