using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.FindDoctor
{
    public class FindDocCityViewModel
    {
        ObservableCollection<PlaceViewModel> _City;
        private string[] Citys;
        public ObservableCollection<PlaceViewModel> City
        {
            get { return _City; }
            set { _City = value; }
        }

        public FindDocCityViewModel(string provcho)
        {
            City = new ObservableCollection<PlaceViewModel>();
            switch (provcho)
            {
                case("北京"):
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
                City.Add(new PlaceViewModel { Place = city });
            }

        }
    }
}
