using IFrame.Models;
using IFrame.Views.Friends;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace IFrame.ViewModels.Friends
{
    class FriendPageViewModel : BaseViewModel, ICarouselViewModel
    {
        public ObservableCollection<FriendInfo> FriendInformations { get; set; }

        public ContentView View
        {
            get { return new FriendPage(); }
        }
        public string FriendTitle
        {
            get
            {
                return "医友";
            }
        }

        public FriendPageViewModel()
        {
            FriendInformations = new ObservableCollection<FriendInfo>();

            FriendInformations.Add(new FriendInfo()
            {
                Name = "添加好友",
                FriendPhoto = "@drawable/addfriend",
                IsFriendInfo = false
            });
            
            FriendInformations.Add(new FriendInfo()
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
            FriendInformations.Add(new FriendInfo()
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
            FriendInformations.Add(new FriendInfo()
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
