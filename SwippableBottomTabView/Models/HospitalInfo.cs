using System;
using System.Collections.Generic;
using System.Text;

namespace IFrame.Models
{
    public class HospitalInfo
    {
        string[] _Beijing = {"北医三院","北医六院","天坛医院","地坛医院","人民医院","协和医院","海淀医院","306医院"};

        public string[] Beijing
        {
            get { return _Beijing; }
        }

        string[] _Tianjin = { "天津医科大学总医院","天津市儿童医院","天津市人民医院","天津市口腔医院","天津市眼科医院","南开医院","天津医院"};

        public string[] Tianjin
        {
            get { return _Tianjin; }
        }

        string[] _Shijiazhuang = { "河北医科大学第二医院","河北省人民医院","河北医科大学第四医院","石家庄市第一医院","河北省中医院","白求恩和平医院"};

        public string[] Shijiazhuang
        {
            get { return _Shijiazhuang; }
        }
    }
}
