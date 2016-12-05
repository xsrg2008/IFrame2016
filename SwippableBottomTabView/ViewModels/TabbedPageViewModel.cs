using IFrame.ViewModels.FindDoctor;
using IFrame.ViewModels.Friends;
using IFrame.ViewModels.UserCenter;
using System.Collections.Generic;
using System.Linq;

namespace IFrame.ViewModels
{
    public class TabbedPageViewModel: BaseViewModel
    {
        public TabbedPageViewModel()
        {
            Pages = new List<ICarouselViewModel>
            {
                new FriendPageViewModel(),
                new FindPageViewModel(),
                new UserPageViewModel()
            };
        }

        private IEnumerable<ICarouselViewModel> _pages;

        public IEnumerable<ICarouselViewModel> Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                SetObservableProperty(ref _pages, value);
                CurrentPage = Pages.FirstOrDefault();
            }
        }

        private ICarouselViewModel _currentPage;

        public ICarouselViewModel CurrentPage
        {
            get
            {
                return _currentPage;
            }
            set
            {
                SetObservableProperty(ref _currentPage, value);
            }
        }
    }
}
