using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.FindDoctor
{
    public class ResultDetailViewModel
    {
        public FriendInfo _friendInfo { set; get; }

        public ObservableCollection<FriendInfo> _searchResult { set; get; }

        
        public ResultDetailViewModel(FriendInfo friendinfo)
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
            _searchResult.Add(new FriendInfo()
            {
                Name = "吴医生",
                Hospital = "北京天坛医院",
                Profession = "内科",
                Job = "主任医师",
                FriendPhoto = "@drawable/doctor1",
                Age = "40",
                Gender = "female",
                Heart = "特熟",
                Relationship = "同事",
                Goodat = "心血管",
                PhoneNumber = "12345678901",
                IsFriendInfo = true
            });
            _searchResult.Add(new FriendInfo()
            {
                Name = "赵医生",
                Hospital = "北京协和医院",
                Profession = "神经科",
                Job = "医师",
                FriendPhoto = "@drawable/doctor2",
                Age = "39",
                Gender = "male",
                Heart = "一般",
                Relationship = "同学",
                Goodat = "癫痫",
                PhoneNumber = "12345678901",
                IsFriendInfo = true
            });
        }
    }
}
