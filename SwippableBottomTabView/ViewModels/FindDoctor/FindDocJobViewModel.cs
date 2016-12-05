
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.FindDoctor
{
    public class FindDocJobViewModel
    {
        public ObservableCollection<JobInfo> Jobs { get; set; }

        public FindDocJobViewModel()
        {
            Jobs= new ObservableCollection<JobInfo>
            {
                new JobInfo { DocJob = "医师" },
                new JobInfo { DocJob = "主治医师" },
                new JobInfo { DocJob = "副主任医师(副教授)" },
                new JobInfo { DocJob = "主任医师（教授）" },
            };
        }
    }

    public class JobInfo
    {
        string _Job;

        public string DocJob
        {
            get { return _Job; }
            set { _Job = value; }
        }
    }
}
