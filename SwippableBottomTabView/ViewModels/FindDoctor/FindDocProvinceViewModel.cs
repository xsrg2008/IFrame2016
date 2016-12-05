using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Xml;
using IFrame.Models;

namespace IFrame.ViewModels.FindDoctor
{
    public class FindDocProvinceViewModel
    {
        ObservableCollection<PlaceViewModel> _Province;
        //     private string[] AllProvince = {"北京","天津","河北","山西","内蒙古","辽宁","吉林","黑龙江","上海","江苏","浙江","安徽","福建","江西","山东","河南","湖北","湖南","广东","广西","海南","重庆","四川","贵州","云南","西藏","陕西","甘肃","青海","宁夏","新疆","香港","澳门","台湾"};
        private string[] AllProvince = new PlaceInfo().Province; 
        public ObservableCollection<PlaceViewModel> Province
        {
            get { return _Province; }
            set { _Province = value; }
        }

        public FindDocProvinceViewModel()
        {
            Province = new ObservableCollection<PlaceViewModel>();
            foreach (string prov in AllProvince)
            {
                Province.Add( new PlaceViewModel { Place = prov });
            }

        }
    }
}
