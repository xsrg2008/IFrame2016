using Rg.Plugins.Popup.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFrame.Views.Dialogs;

using Xamarin.Forms;
using IFrame.Views.FindDoctor;
using IFrame.ViewModels.FindDoctor;
using IFrame.ViewModels.UserCenter;
using IFrame.Views.Dialogs.UserCenter;

namespace IFrame.Views.UserCenter
{
    public partial class DetailInfo : ContentPage
    {
        string _Province;
        string _City;
        string _Hospital;
        string _Profession;
        string _Job;
        string _Interst;
        string _Name;
        string _Telphone;
        string _Sex;
        string _Birth;
        string _Benke;
        string _Masrer;
        string _Doctor;
        string _Jinxiu;

        public EventHandler<FocusEventArgs> MyBirthDatePickerEvent { get; private set; }

        public DetailInfo()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            InitializeComponent();

            _Province = "";
            _City = "";
            _Hospital = "";
            _Profession = "";
            _Job = "";
            _Interst = "";
            _Name = "";
            _Telphone = "";
            _Sex = "";
            _Birth = "";
            _Benke = "";
            _Masrer = "";
            _Doctor = "";
            _Jinxiu = "";
            MessagingCenter.Subscribe<MyName, string>(this, "MYNAME", (sender, arg) =>
            {
                _Name = arg;
                if (arg == "")
                { MyNameLable.Text = "未选择"; }
                else { MyNameLable.Text = arg; }

            });

            MessagingCenter.Subscribe<MySex, string>(this, "MYSEX", (sender, arg) =>
            {
                _Sex = arg;
                MySexLabel.Text = arg;
            });

            MessagingCenter.Subscribe<MySexold, string>(this, "MYSEXOLD", (sender, arg) =>
            {
                _Sex = arg;
                MySexLabel.Text = arg;
            });



            MessagingCenter.Subscribe<MyTelphone, string>(this, "MYTELPHONE", (sender, arg) =>
            {
                _Telphone = arg;
                if (arg == "")
                { MyTelphoneLabel.Text = "未输入"; }
                else { MyTelphoneLabel.Text = arg; }

            });


            MessagingCenter.Subscribe<MySchool, string>(this, "MYBENKE", (sender, arg) =>
            {
                _Benke = arg;
                MyBenkeLabel.Text = arg;
            });

            MessagingCenter.Subscribe<MySchool, string>(this, "MYMASTER", (sender, arg) =>
            {
                _Masrer = arg;
                MyMasrerLabel.Text = arg;
            });
            MessagingCenter.Subscribe<MySchool, string>(this, "MYDOCTOR", (sender, arg) =>
            {
                _Doctor = arg;
                MyDoctorLabel.Text = arg;
            });
            MessagingCenter.Subscribe<MySchool, string>(this, "MYJINXIU", (sender, arg) =>
            {
                _Jinxiu = arg;
                MyJinxiuLabel.Text = arg;
            });

            MessagingCenter.Subscribe<MyCity, string>(this, "MYCITY", (sender, arg) =>
            {
                _City = arg;
                MyPlaceLabel.Text = arg;
            });

            MessagingCenter.Subscribe<MyHospital, string>(this, "MYHOSPITAL", (sender, arg) =>
            {
                _Hospital = arg;
                MyUnitsLabel.Text = arg;
            });

            MessagingCenter.Subscribe<MyProfession, string>(this, "MYPROFESSION", (sender, arg) =>
            {
                _Profession = arg;
                MyProfessionLabel.Text = arg;
            });


            MessagingCenter.Subscribe<MyJob, string>(this, "MYJOB", (sender, arg) =>
            {
                _Job = arg;
                MyJobLabel.Text = arg;
            });

            MessagingCenter.Subscribe<MyInterest, string>(this, "MYINTEREST", (sender, arg) =>
            {
                _Interst = arg;
                if (arg == "")
                { MyInterestLable.Text = "未输入"; }
                else { MyInterestLable.Text = arg; }

            });

        }

        private void OnMynameCell(object sender, EventArgs e)
        {
            Navigation.PushPopupAsync(new MyName(_Name));
        }



        private void OnSexCell(object sender, EventArgs e)
        {
            //    //Navigation.PushPopupAsync(new MyTelphone(_Telphone));
            //Navigation.PushAsync(new MySex() { BindingContext = new MySexViewModel() });
            Navigation.PushPopupAsync(new MySexold() { BindingContext = new MySexViewModel() });
            //    //Navigation.PushPopupAsync(new MySex() { BindingContext = new MySexViewModel() }); 
        }


        private void OnTelCell(object sender, EventArgs e)
        {
            Navigation.PushPopupAsync(new MyTelphone(_Telphone));
        }

        private void OnBirthCell(object sender, EventArgs e)
        {
            //Navigation.PushPopupAsync(new MyBirth());

        }



        private void OnBenkeCell(object sender, EventArgs e)
        {
            string arg = "MYBENKE";
            Navigation.PushAsync(new MyProvinceSchool(arg) { BindingContext = new MyProvinceViewModel() });
        }

        private void OnMasterCell(object sender, EventArgs e)
        {
            string arg = "MYMASTER";
            Navigation.PushAsync(new MyProvinceSchool(arg) { BindingContext = new MyProvinceViewModel() });
        }
        private void OnDoctorCell(object sender, EventArgs e)
        {
            string arg = "MYDOCTOR";
            Navigation.PushAsync(new MyProvinceSchool(arg) { BindingContext = new MyProvinceViewModel() });
        }
        private void OnJinxiuCell(object sender, EventArgs e)
        {
            string arg = "MYJINXIU";
            Navigation.PushAsync(new MyProvinceSchool(arg) { BindingContext = new MyProvinceViewModel() });
        }

        private void OnPlaceCell(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyProvince() { BindingContext = new MyProvinceViewModel() });
        }
        private void OnHospitalCell(object sender, EventArgs e)
        {
            if (_City == "")
            {
                Navigation.PushPopupAsync(new ChoosePlaceFirst());
            }
            else
            {
                Navigation.PushAsync(new MyHospital() { BindingContext = new MyHospitalViewModel(_City) });
            }
        }



        private void OnProfessionCell(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyProfession() { BindingContext = new MyProfessionViewModel() });
        }


        private void OnJobCell(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MyJob() { BindingContext = new MyJobViewModel() });
        }


        private void OnInterstCell(object sender, EventArgs e)
        {
            Navigation.PushPopupAsync(new MyInterest(_Interst));
        }


        private void OnFhCicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }

        private void OnAlert(object sender, ToggledEventArgs e)
        {
            DisplayAlert("shengji", "shengji！", "确定");
        }

        private void OnCleanApp(object sender, EventArgs e)
        {
            Navigation.PushPopupAsync(new CleanApp());
        }
        private void OnUpdateApp(object sender, EventArgs e)
        {

            Navigation.PushPopupAsync(new NoUpdate());

        }

        private void OnAbout(object sender, EventArgs e)
        {
            Navigation.PushPopupAsync(new AboutApp());
        }
    }
}
