using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.FindDoctor
{
    public class SearchResultsViewModel
    {
        public ObservableCollection<FriendInfo> SearchResultsLists { get; set; }

        public SearchResultsViewModel()
        {
            SearchResultsLists = new ObservableCollection<FriendInfo>();

            SearchResultsLists.Add(new FriendInfo()
            {
                Name = "孙医生",
                Hospital = "北医六院",
                Profession = "内科",
                Job = "主任医师",
                FriendPhoto = "@drawable/doctor3",
                Age = "40",
                Gender = "male",
                Goodat = "神经内科",
                Relationship = "同学",
                IsRegister = true

            });
            SearchResultsLists.Add(new FriendInfo()
            {
                Name = "柳医生",
                Hospital = "北京人民医院",
                Profession = "内科",
                Job = "医师",
                FriendPhoto = "@drawable/doctor4",
                Age = "36",
                Gender = "female",
                Goodat = "神经内科",
                Relationship = "同事",
                IsRegister = false
            });
        }
    }
}
