using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.Friends
{
    public class AddFriendViewModel
    {
        public ObservableCollection<FriendInfo> FriendInformations { get; set; }

        public AddFriendViewModel()
        {
            FriendInformations = new ObservableCollection<FriendInfo>();

            FriendInformations.Add(new FriendInfo()
            {
                Name = "孙医生",
                Hospital = "北医六院",
                Profession = "心理科",
                Job = "主任医师",
                FriendPhoto = "@drawable/doctor3",
                Age = "40",
                Gender = "male",
                Relationship = "同学",

            });
            FriendInformations.Add(new FriendInfo()
            {
                Name = "柳医生",
                Hospital = "北京人民医院",
                Profession = "内科",
                Job = "医师",
                FriendPhoto = "@drawable/doctor5",
                Age = "36",
                Gender = "female",
                Relationship = "同事",
            });
        }
    }
}
