
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.UserCenter
{
    public class MyJobViewModel
    {
        public ObservableCollection<MyJobInfo> MyJobs { get; set; }

        public MyJobViewModel()
        {
            MyJobs = new ObservableCollection<MyJobInfo>
            {
                new MyJobInfo { MyJob = "医师" },
                new MyJobInfo { MyJob = "主治医师" },
                new MyJobInfo { MyJob = "副主任医师(副教授)" },
                new MyJobInfo { MyJob = "主任医师（教授）" },
            };
        }
    }

    public class MyJobInfo
    {
        string _Job;

        public string MyJob
        {
            get { return _Job; }
            set { _Job = value; }
        }
    }
}
