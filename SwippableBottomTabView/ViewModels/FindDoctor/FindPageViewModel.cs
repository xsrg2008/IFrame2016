using IFrame.Views.FindDoctor;
using Xamarin.Forms;

namespace IFrame.ViewModels.FindDoctor
{
    class FindPageViewModel: BaseViewModel, ICarouselViewModel
    {
        public ContentView View
        {
            get { return new FindPage(); }
        }

        public string FindTitle
        {
            get
            {
                return "找医生";
            }
        }
    }
}
