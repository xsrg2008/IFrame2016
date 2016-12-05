using System;

namespace IFrame.Models
{
    public class FriendInfo
    {
        public string Id { get; set; } //用户唯一标示

        public string Name { get; set; }

        public string Job { get; set; }      //职称

        public string Profession { get; set; }   //科室

        public string Hospital { get; set; }

        public string Goodat { get; set; }

        public string FriendPhoto { get; set; }

        public string Gender { get; set; }

        public string Age { get; set; }

        public string Relationship { get; set; }

        public string Heart { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsFriendInfo { get; set; }

        public bool IsRegister { get; set; }

        public string HosiptalPJob { get { return Hospital +"   "+Job; } }

        public string MayRelation { get { return "可能是你的" + Relationship; } }

        public string Register
        {
            get
            {
                if (IsRegister == true)
                    return "注册用户";
                else return "其他用户完善资料";
            }
        }
    }
}
