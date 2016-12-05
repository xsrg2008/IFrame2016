using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.UserCenter
{
    public class MySexViewModel
    {
        private string[] Sexss;
        ObservableCollection<MySexViewModelInfo> _SexList;
        public ObservableCollection<MySexViewModelInfo> MySexsList
        {
            get { return _SexList; }
            set { _SexList = value; }
        }
        public MySexViewModel()
        {
            MySexsList = new ObservableCollection<MySexViewModelInfo>();
            Sexss = new SexInfo().Sexs;
            foreach (string sex in Sexss)
            {
                MySexsList.Add(new MySexViewModelInfo { MySex = sex });
            }

        }

    }

    public class MySexViewModelInfo
    {
        string _Sex;
        public string MySex
        {
            get { return _Sex; }
            set { _Sex = value; }
        }
    }
}
