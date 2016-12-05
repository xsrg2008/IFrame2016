using System;
using System.Collections.Generic;
using System.Text;

namespace IFrame.Models
{
    public class ProfessionInfo
    {
        string[] _Professions = {"内科","外科","神经科","口腔科","皮肤科","泌尿科"};

        public string[] Professions
        {
            get { return _Professions; }
        }
    }
}
