using System;
using System.Collections.Generic;
using System.Text;

namespace IFrame.Models
{
    public class PlaceInfo
    {
        string[] _Province = { "北京", "天津", "河北", "山西", "内蒙古", "辽宁", "吉林", "黑龙江", "上海", "江苏", "浙江", "安徽", "福建", "江西", "山东", "河南", "湖北", "湖南", "广东", "广西", "海南", "重庆", "四川", "贵州", "云南", "西藏", "陕西", "甘肃", "青海", "宁夏", "新疆", "香港", "澳门", "台湾" };

        public string[] Province
        {
            get{ return _Province; } 
        }

        string[] _BeijingCity = {"北京"};

        public string[] BeiingCity
        {
            get { return _BeijingCity; }
        }

        string[] _TianjinCity = { "天津" };

        public string[] TianjinCity
        {
            get { return _TianjinCity; }
        }

        string[] _HeibeiCity = {"石家庄","秦皇岛","唐山","邢台"};

        public string[] HeibeiCity
        {
            get { return _HeibeiCity; }
        }

    }
}
