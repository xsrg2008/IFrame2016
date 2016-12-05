using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using IFrame.Models;

namespace IFrame.ViewModels.FindDoctor
{
    public class FindDocProfessionViewModel
    {
        private string[] Pros;
        ObservableCollection<ProfessionViewModel> _ProfessionList;
        public ObservableCollection<ProfessionViewModel> ProfessionList
        {
            get { return _ProfessionList; }
            set { _ProfessionList = value; }
        }

        public FindDocProfessionViewModel()
        {
            ProfessionList = new ObservableCollection<ProfessionViewModel>();
            Pros = new ProfessionInfo().Professions;
            foreach (string pro in Pros)
            {
                ProfessionList.Add(new ProfessionViewModel { Profession = pro });
            }
        }
    }

    public class ProfessionViewModel
    {
        string _Profession;

        public string Profession
        {
            get { return _Profession; }
            set { _Profession = value; }
        }
    }
}
