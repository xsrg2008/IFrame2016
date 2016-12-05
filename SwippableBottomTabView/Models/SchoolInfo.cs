using System;
using System.Collections.Generic;
using System.Text;

namespace IFrame.Models
{
    public class SchoolInfo
    {

        string[] _Beijing = { "北京大学", "清华大学", "中国人民大学", "北京师范大学", "北京航空航天大学", "北京理工大学", "中国农业大学", "北京科技大学" };

        public string[] Beijing
        {
            get { return _Beijing; }
        }

        string[] _Tianjin = { "南开大学", "天津大学", "天津师范大学", "天津医科大学", "天津工业大学", "天津中医药大学", "天津财经大学" };

        public string[] Tianjin
        {
            get { return _Tianjin; }
        }

        string[] _Shijiazhuang = { "河北地质大学", "河北科技大学", "河北医科大学", "河北师范大学", "石家庄学院", "石家庄铁道大学" };

        public string[] Shijiazhuang
        {
            get { return _Shijiazhuang; }

        }
    }
}
