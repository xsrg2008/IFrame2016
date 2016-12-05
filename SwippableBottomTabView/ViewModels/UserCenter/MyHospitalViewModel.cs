using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.UserCenter
{
    public class MyHospitalViewModel
    {
        ObservableCollection<MyHospitalViewModelinfo> _HospitalList;
        private string[] Hospitals;
        public ObservableCollection<MyHospitalViewModelinfo> MyHospitalList
        {
            get { return _HospitalList; }
            set { _HospitalList = value; }
        }

        public MyHospitalViewModel(string city)
        {
            MyHospitalList = new ObservableCollection<MyHospitalViewModelinfo>();
            switch (city)
            {
                case ("北京"):
                    Hospitals = new HospitalInfo().Beijing;
                    break;
                case ("天津"):
                    Hospitals = new HospitalInfo().Tianjin;
                    break;
                case ("石家庄"):
                    Hospitals = new HospitalInfo().Shijiazhuang;
                    break;

            }
            foreach (string hos in Hospitals)
            {
                MyHospitalList.Add(new MyHospitalViewModelinfo { MyHospital = hos });
            }
        }
    }

    public class MyHospitalViewModelinfo
    {
        string _Hospital;

        public string MyHospital
        {
            get { return _Hospital; }
            set { _Hospital = value; }
        }
    }
}
