using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.UserCenter
{
    public class MyCityViewModel
    {
        ObservableCollection<MyCityPlaceViewModel> _City;
        private string[] Citys;
        public ObservableCollection<MyCityPlaceViewModel> MyCity
        {
            get { return _City; }
            set { _City = value; }
        }

        public MyCityViewModel(string provcho)
        {
            MyCity = new ObservableCollection<MyCityPlaceViewModel>();
            switch (provcho)
            {
                case ("北京"):
                    Citys = new PlaceInfo().BeiingCity;
                    break;
                case ("天津"):
                    Citys = new PlaceInfo().TianjinCity;
                    break;
                case ("河北"):
                    Citys = new PlaceInfo().HeibeiCity;
                    break;
            }
            foreach (string city in Citys)
            {
                MyCity.Add(new MyCityPlaceViewModel { MyPlace = city });
            }

        }
    }

    public class MyCityPlaceViewModel
    {
        string _Place;

        public string MyPlace
        {
            get { return _Place; }
            set { _Place = value; }
        }
    }
}
