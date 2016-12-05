using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.FindDoctor
{
    public class FindDocHospitalViewModel
    {
        ObservableCollection<HospitalViewModel> _HospitalList;
        private string[] Hospitals;
        public ObservableCollection<HospitalViewModel> HospitalList
        {
            get { return _HospitalList; }
            set { _HospitalList = value; }
        }

        public FindDocHospitalViewModel(string city)
        {
            HospitalList = new ObservableCollection<HospitalViewModel>();
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
                HospitalList.Add(new HospitalViewModel { Hospital = hos });
            }
        }
    }

    public class HospitalViewModel
    {
        string _Hospital;

        public string Hospital
        {
            get { return _Hospital; }
            set { _Hospital = value; }
        }
    }
}
