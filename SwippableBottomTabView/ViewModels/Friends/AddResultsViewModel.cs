using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.Friends
{
    public class AddResultsViewModel
    {
        public ObservableCollection<FriendInfo> Results { get; set; }

        public AddResultsViewModel()
        {
            Results = new ObservableCollection<FriendInfo>();

            Results.Add(new FriendInfo()
            {
                Name = "张医生",
                Hospital = "北医六院",
                Profession = "心理科",
                Job = "主任医师",
                FriendPhoto = "@drawable/doctor5",
                Age = "40",
                Gender = "male",
                Relationship = "同学",
            });
        }
    }
}
