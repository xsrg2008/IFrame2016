using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.UserCenter
{
    public class MySchoolViewModel
    {
        ObservableCollection<MySchoolViewModelinfo> _SchoolList;
        private string[] Schools;
        public ObservableCollection<MySchoolViewModelinfo> MySchoolList
        {
            get { return _SchoolList; }
            set { _SchoolList = value; }
        }

        public MySchoolViewModel(string city)
        {
            MySchoolList = new ObservableCollection<MySchoolViewModelinfo>();
            switch (city)
            {
                case ("北京"):
                    Schools = new SchoolInfo().Beijing;
                    break;
                case ("天津"):
                    Schools = new SchoolInfo().Tianjin;
                    break;
                case ("石家庄"):
                    Schools = new SchoolInfo().Shijiazhuang;
                    break;

            }
            foreach (string sch in Schools)
            {
                MySchoolList.Add(new MySchoolViewModelinfo { MySchool = sch });
            }
        }
    }

    public class MySchoolViewModelinfo
    {
        string _MySchool;

        public string MySchool
        {
            get { return _MySchool; }
            set { _MySchool = value; }
        }
    }
}
