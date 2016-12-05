using IFrame.Controls;
using IFrame.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using Xamarin.Forms;

namespace IFrame
{
    public class HomePage : ContentPage
    {
        private View _tabs;

        private RelativeLayout _relativeLayout;

        private TabbedPageViewModel _viewModel;

        public HomePage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            _viewModel = new TabbedPageViewModel();
            BindingContext = _viewModel;

            BackgroundColor = Color.White;

            _relativeLayout = new RelativeLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            
            var pagesCarousel = CreatePagesCarousel();
            _tabs = CreateTabs();

            var tabsHeight = 50;
            _relativeLayout.Children.Add(_tabs,
                        Constraint.Constant(0),
                        Constraint.RelativeToParent((parent) => { return parent.Height - tabsHeight; }),
                        Constraint.RelativeToParent(parent => parent.Width),
                        Constraint.Constant(tabsHeight)
                    );

                    _relativeLayout.Children.Add(pagesCarousel,
                        Constraint.RelativeToParent((parent) => { return parent.X; }),
                        Constraint.RelativeToParent((parent) => { return parent.Y; }),
                        Constraint.RelativeToParent((parent) => { return parent.Width; }),
                        Constraint.RelativeToView(_tabs, (parent, sibling) => { return parent.Height - (sibling.Height); })
                    );

            Content = _relativeLayout;
        }

 /*     private void InitializeToolBarItems()
        {
            ToolbarItem _addTalk = new ToolbarItem("Add Talk", "@drawable/add", () => {
                DisplayAlert("Add new talk", "Add a new talk here", "Create talk");
            }, (ToolbarItemOrder)1);

            Title = "医友";

            ToolbarItems.Add(_addTalk);
            
        }
*/
        private CarouselLayout CreatePagesCarousel()
        {
            var carousel = new CarouselLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                ItemTemplate = new DataTemplate(typeof(DynamicTemplateLayout))
            };
            carousel.SetBinding(CarouselLayout.ItemsSourceProperty, "Pages");
            carousel.SetBinding(CarouselLayout.SelectedItemProperty, "CurrentPage", BindingMode.TwoWay);

            return carousel;
        }

        private View CreateTabs()
        {
            var pagerIndicator = new PageTabs() { HorizontalOptions = LayoutOptions.CenterAndExpand };
            pagerIndicator.RowDefinitions.Add(new RowDefinition() { Height = 50 });
            //pagerIndicator.SetBinding(Grid.ColumnDefinitionsProperty, "Pages", BindingMode.Default, new SpacingConverter());
            pagerIndicator.SetBinding(PageTabs.ItemsSourceProperty, "Pages");
            pagerIndicator.SetBinding(PageTabs.SelectedItemProperty, "CurrentPage");

            return pagerIndicator;
        }
    }

    public class SpacingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var items = value as IEnumerable<ICarouselViewModel>;

            var collection = new ColumnDefinitionCollection();
            foreach (var item in items)
            {
                collection.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });
            }
            return collection;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}