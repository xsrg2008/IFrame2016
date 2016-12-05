using System.Collections;
using System.Linq;
using System.Reflection;
using Xamarin.Forms;

namespace IFrame
{
    public class PageTabs : Grid
    {
        private int _selectedIndex;

        public PageTabs()
        {
            HorizontalOptions = LayoutOptions.CenterAndExpand;
            VerticalOptions = LayoutOptions.Center;
            RowSpacing = ColumnSpacing = 0;

            var assembly = typeof(PageTabs).GetTypeInfo().Assembly;
            foreach (var res in assembly.GetManifestResourceNames())
                System.Diagnostics.Debug.WriteLine("found resource: " + res);
        }

        private void CreateTabs()
        {
            if (Children != null && Children.Count > 0) Children.Clear();

            foreach (var item in ItemsSource)
            {
                var index = Children.Count;
                var tab = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    Padding = new Thickness(7)
                };
               
                if(index == 0)
                {
                    tab.Children.Add(new Image { Source = "friend.png", HeightRequest = 25 });
                    tab.Children.Add(new Label
                    {
                        TextColor = Color.Gray,
                        Text = "医友" ,
                        FontSize = 11,
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    });
                }
                else if(index == 1)
                {
                    tab.Children.Add(new Image { Source = "finddoctor.png", HeightRequest = 25 });
                    tab.Children.Add(new Label
                    {
                        TextColor = Color.Gray,
                        Text = "找医生",
                        FontSize = 11,
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    });
                }
                else 
                {
                    tab.Children.Add(new Image { Source = "me.png", HeightRequest = 25 });
                    tab.Children.Add(new Label
                    {
                        TextColor = Color.Gray,
                        Text = "我",
                        FontSize = 11,
                        HorizontalOptions = LayoutOptions.CenterAndExpand
                    });
                }

                var tgr = new TapGestureRecognizer();
                tgr.Command = new Command(() =>
                {
                    SelectedItem = ItemsSource[index];
                });
                tab.GestureRecognizers.Add(tgr);
                Children.Add(tab, index, 0);
            }
        }

        public static BindableProperty ItemsSourceProperty =
            BindableProperty.Create<PageTabs, IList>(
                pi => pi.ItemsSource,
                null,
                BindingMode.OneWay,
                propertyChanging: (bindable, oldValue, newValue) =>
                {
                    ((PageTabs)bindable).ItemsSourceChanging();
                },
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    ((PageTabs)bindable).ItemsSourceChanged();
                }
        );

        public IList ItemsSource
        {
            get
            {
                return (IList)GetValue(ItemsSourceProperty);
            }
            set
            {
                SetValue(ItemsSourceProperty, value);
            }
        }

        public static BindableProperty SelectedItemProperty =
            BindableProperty.Create<PageTabs, object>(
                pi => pi.SelectedItem,
                null,
                BindingMode.TwoWay,
                propertyChanged: (bindable, oldValue, newValue) =>
                {
                    ((PageTabs)bindable).SelectedItemChanged();
                });

        public object SelectedItem
        {
            get
            {
                return GetValue(SelectedItemProperty);
            }
            set
            {
                SetValue(SelectedItemProperty, value);
            }
        }

        private void ItemsSourceChanging()
        {
            if (ItemsSource != null)
                _selectedIndex = ItemsSource.IndexOf(SelectedItem);
        }

        private void ItemsSourceChanged()
        {
            if (ItemsSource == null) return;

            CreateTabs();
        }

        private void SelectedItemChanged()
        {
            var selectedIndex = ItemsSource.IndexOf(SelectedItem);
            var pagerIndicators = Children.Cast<StackLayout>().ToList();

            foreach (var pi in pagerIndicators)
            {
                UnselectTab(pi);
            }

            if (selectedIndex > -1)
            {
                SelectTab(pagerIndicators[selectedIndex]);
            }

  /*          switch (selectedIndex)
            {
                case 0:
                    ToolbarItem _addTalk = new ToolbarItem("Add Talk", "@drawable/add", () => {
                        NavigationPage.DisplayAlert("Add new talk", "Add a new talk here", "Create talk");
                    }, (ToolbarItemOrder)1);
                    NavigationPage.ToolbarItems.Add(_addTalk);
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }*/
                
        }

        private static void UnselectTab(StackLayout tab)
        {
            tab.Opacity = 0.5;
        }

        private static void SelectTab(StackLayout tab)
        {
            tab.Opacity = 1.0;
        }
    }
}