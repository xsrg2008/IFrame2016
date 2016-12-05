using IFrame.ViewModels;
using IFrame.ViewModels.UserCenter;
using IFrame.Views;
using IFrame.Views.Cells;
using IFrame.Views.Dialogs;
using IFrame.Views.Friends;
using Rg.Plugins.Popup.Extensions;
using Xamarin.Forms;

namespace IFrame.Views.UserCenter
{
    class UserPage : ContentView
    {
        public UserPage()
        {
            UserPageViewModel _meViewModel = new UserPageViewModel();
            string gender = _meViewModel.Gender;
            BackgroundColor = Color.FromRgb(245, 245, 245);

            var label = new Label()
            {
                Text = "个人中心",
                TextColor = Color.White,
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HeightRequest = 55,
                BackgroundColor = Color.FromHex("ffdda0"),
                //HorizontalOptions = LayoutOptions.Fill,
                //VerticalOptions = LayoutOptions.Start
            };
            
            var backgroundImage = new Image()
            {
                Source = "@drawable/personpage",
                Aspect = Aspect.Fill	
            };

            var face = new Image()
            {
                Aspect = Aspect.Fill,
                Source = "@drawable/user"
            };

            var User = new Label()
            {
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 22,
                HeightRequest = 24
            };
            User.SetBinding<UserPageViewModel>(Label.TextProperty, vm => vm.UserName);

            var SexImage = new Image()
            {
               Aspect = Aspect.Fill
            };
            if (gender == "female")
            {
                SexImage.Source = "@drawable/female";
            }
            else
            {
                SexImage.Source = "@drawable/male";
            }
                 
            var Age = new Label()
            {
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 18,
                HeightRequest = 20
            };
            Age.SetBinding<UserPageViewModel>(Label.TextProperty, vm => vm.AgeNum);

            var box = new BoxView()
            {
                BackgroundColor = Color.White,
                HorizontalOptions = LayoutOptions.Fill,

            };

            var changeDataCell = new ChangeDataCell();
            changeDataCell.Tapped += (sender, e) =>
            {
                //Navigation.PushAsync(new AddFriendPage());
                Navigation.PushAsync(new DetailInfo());
            };
           
            var settingCell = new SettingCell();
            settingCell.Tapped += (sender, e) =>
            {
                Navigation.PushAsync(new SetPage());
            };
            var table = new TableView
            {
                VerticalOptions = LayoutOptions.Start,
                Intent = TableIntent.Settings,
                Root = new TableRoot()
                {   new TableSection()
                    {
                        changeDataCell,
                        settingCell
                     }
                 }
            };


            RelativeLayout relativeLayout = new RelativeLayout();

            relativeLayout.Children.Add(
                box,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) => {
                    return ( parent.Height * .325 + 100 );
                })
            );

            relativeLayout.Children.Add(
                label,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.Constant(55)
            );

            relativeLayout.Children.Add(
                backgroundImage,
                Constraint.Constant(0),
                Constraint.Constant(55),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height * .20;
                })
            );

            relativeLayout.Children.Add(
                face,
                Constraint.RelativeToParent((parent) => {
                    return ((parent.Width / 2) - (parent.Width * .25/2));
                }),
                Constraint.RelativeToParent((parent) => {
                    return ((55+ backgroundImage.Height) - (parent.Width * .25 / 2));
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width * .25;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width * .25;
                })
            );

            relativeLayout.Children.Add(
                User,
                Constraint.RelativeToParent((parent) => {
                    return ((parent.Width / 2) - (User.Width / 2));
                }),
                Constraint.RelativeToParent((parent) => {
                    return (55 + backgroundImage.Height + parent.Width * .25/2 + 20);
                })
                //Constraint.Constant(70),
                //Constraint.Constant(28)
            );

            relativeLayout.Children.Add(
                SexImage,
                Constraint.RelativeToView(User,(parent,View) => {
                    return (View.X + View.Width + 10);
                }),
                Constraint.RelativeToView(User, (parent, View) => {
                    return (View.Y + View.Height/2 - 5);
                }),
                Constraint.Constant(50),
                Constraint.Constant(20)
            );

            relativeLayout.Children.Add(
                Age,
                Constraint.RelativeToView(SexImage, (parent, View) => {
                    return (View.X + 24);
                }),
                Constraint.RelativeToView(SexImage, (parent, View) => {
                    return (View.Y + View.Height/2 - Age.Height/2 - 3);
                })
            );

            relativeLayout.Children.Add(
               table,
               Constraint.Constant(0),
               Constraint.RelativeToView(box, (parent, View) => {
                   return (View.Y + View.Height);
               })
           );

            Content = relativeLayout;
        }
    }
}
