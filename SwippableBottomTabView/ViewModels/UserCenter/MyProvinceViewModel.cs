using IFrame.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace IFrame.ViewModels.UserCenter
{
    public class MyProvinceViewModel
    {
        ObservableCollection<MyPlaceViewModel> _Province;
        //     private string[] AllProvince = {"北京","天津","河北","山西","内蒙古","辽宁","吉林","黑龙江","上海","江苏","浙江","安徽","福建","江西","山东","河南","湖北","湖南","广东","广西","海南","重庆","四川","贵州","云南","西藏","陕西","甘肃","青海","宁夏","新疆","香港","澳门","台湾"};
        private string[] AllProvince = new PlaceInfo().Province;
        public ObservableCollection<MyPlaceViewModel> MyProvince
        {
            get { return _Province; }
            set { _Province = value; }
        }

        public MyProvinceViewModel()
        {
            MyProvince = new ObservableCollection<MyPlaceViewModel>();
            foreach (string prov in AllProvince)
            {
                MyProvince.Add(new MyPlaceViewModel { MyPlace = prov });
            }

        }
    }

    public class MyPlaceViewModel
    {
        string _Place;

        public string MyPlace
        {
            get { return _Place; }
            set { _Place = value; }
        }
    }
}
