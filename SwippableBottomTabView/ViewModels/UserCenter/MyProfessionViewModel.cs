using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.UserCenter
{
    public class MyProfessionViewModel
    {
        private string[] Pros;
        ObservableCollection<MyProfessionViewModelInfo> _ProfessionList;
        public ObservableCollection<MyProfessionViewModelInfo> MyProfessionList
        {
            get { return _ProfessionList; }
            set { _ProfessionList = value; }
        }

        public MyProfessionViewModel()
        {
            MyProfessionList = new ObservableCollection<MyProfessionViewModelInfo>();
            Pros = new ProfessionInfo().Professions;
            foreach (string pro in Pros)
            {
                MyProfessionList.Add(new MyProfessionViewModelInfo { MyProfession = pro });
            }
        }
    }

    public class MyProfessionViewModelInfo
    {
        string _Profession;

        public string MyProfession
        {
            get { return _Profession; }
            set { _Profession = value; }
        }
    }
}
