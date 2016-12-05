using IFrame.Views.UserCenter;
using Java.Nio.Charset;
using Xamarin.Forms;

namespace IFrame.ViewModels.UserCenter
{
    class UserPageViewModel : BaseViewModel, ICarouselViewModel
    {
        public ContentView View
        {
            get { return new UserPage(); }
        }
        
        public string UserName
        {
            get
            {
                return "姚医生";
            }
        }

        public string AgeNum
        {
            get
            {
                return "35";
            }
        }

        public string Gender
        {
            get { return "male"; }
        }
    }
}