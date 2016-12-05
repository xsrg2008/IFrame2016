using System;
using System.Collections.Generic;
using System.Text;
using IFrame.ViewModels;
using Xamarin.Forms;
using IFrame.ViewModels.Friends;
using IFrame.Views.Dialogs;
using Rg.Plugins.Popup.Extensions;
using Plugin.Messaging;

namespace IFrame.Views.Friends
{
    public class FriendDetailPage : ContentPage
    {
        public FriendDetailViewModel ViewModel => BindingContext as FriendDetailViewModel;
        //private string _heart;

        public FriendDetailPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            BackgroundColor = Color.White;
/*
            var SexLabel = new Label();
            SexLabel.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Gender);
            var HeartLabel = new Label();
            HeartLabel.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Heart);
*/
            var box = new BoxView
            {
                Color = Color.FromHex("ffdda0"),
                WidthRequest = 55,
                HeightRequest = 55,
                HorizontalOptions = LayoutOptions.End,
                //              VerticalOptions = LayoutOptions.CenterAndExpand
            };

            var label = new Label()
            {
                HeightRequest = 55,
                BackgroundColor = Color.FromHex("ffdda0"),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.Center
            };
            
            var button = new Button
            {
                Image = "@drawable/fanhui",
                HorizontalOptions = LayoutOptions.Start,
                BackgroundColor = Color.FromHex("ffdda0"),
                WidthRequest = 55,
                HeightRequest = 55,
                BorderRadius = 0,
            };
            button.Clicked += OnButtonClicked;

            var Edit = new Button
            {
                Image = "@drawable/edit",
                BackgroundColor = Color.Transparent,

            };
            Edit.Clicked += (s, e) => Navigation.PushPopupAsync(new ChangeRelation(ViewModel._friendInfo.Relationship, ViewModel._friendInfo.Heart));

            var Call = new Button
            {
                Text = "电话",
                TextColor = Color.White,
                FontSize = 16,
                Image = "@drawable/call",
                HeightRequest = 40,
                WidthRequest = 100,
                BackgroundColor = Color.Green,
                BorderRadius = 15,
            };
            Call.Clicked += (s, e) => {
                var phoneDialer = CrossMessaging.Current.PhoneDialer;
                if (phoneDialer.CanMakePhoneCall)
                    phoneDialer.MakePhoneCall(ViewModel._friendInfo.PhoneNumber);
            };

            var WeChat = new Button
            {
                Text = "微信",
                TextColor = Color.White,
                FontSize = 16,
                Image = "@drawable/wechat",
                HeightRequest = 40,
                WidthRequest = 100,
                BackgroundColor = Color.Blue,
                BorderRadius = 15,
            };

            var SendMess = new Button
            {
                Text = "消息",
                TextColor = Color.White,
                FontSize = 16,
                Image = "@drawable/message",
                HeightRequest = 40,
                WidthRequest = 100,
                BackgroundColor = Color.Olive,
                BorderRadius = 15,
            };

            var MyLable = new StackLayout
            {
                Spacing = 0,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    button,
                    label,
                    box
                }
            };

            var backgroundImage = new Image()
            {
                Source = "@drawable/personpage",
                //VerticalOptions = LayoutOptions.Start,
                Aspect = Aspect.Fill
            };

            var face = new Image()
            {
                Aspect = Aspect.Fill
            };
            face.SetBinding<FriendDetailViewModel>(Image.SourceProperty, vm => vm._friendInfo.FriendPhoto);

            var User = new Label()
            {
                //Text = Binding(_friendInfo.Name),
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 22,
                //               HorizontalOptions = LayoutOptions.Center,
                HeightRequest = 24
            };
            User.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Name);

            var SexImage = new Image()
            {
                Source = "@drawable/male",
                HeightRequest = 20,
                WidthRequest = 50,
                Aspect = Aspect.Fill
            };
            


            var Age = new Label()
            {
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 18,
                HeightRequest = 20
            };
            Age.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Age);

            var RelationG = new Image()
            {
                Source = "@drawble/relation",
                Aspect = Aspect.Fill,
                HeightRequest = 20,
                WidthRequest = 70
            };

            var Relation = new Label()
            {
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 18,
                HeightRequest = 20
            };
            Relation.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Relationship);

            var HeartG = new Image()
            {
                Source = "@drawble/heartground",
                Aspect = Aspect.Fill,
                HeightRequest = 20,
                WidthRequest = 70
            };
            
                
            var HeartDU = new Label()
            {
                TextColor = Color.White,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                FontSize = 18,
                HeightRequest = 20
            };
            HeartDU.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Heart);

            var table = new TableView
            {
                VerticalOptions = LayoutOptions.Start,
                Intent = TableIntent.Settings,
                Root = new TableRoot()
                {
                    new TableSection()
                    {
                        new HospitalCell(),
                        new ProfessionCell(),
                        new GoodatCell(),
                        new JobCell()
                    }
                }
            };

            
            RelativeLayout relativeLayout = new RelativeLayout()
            {
                // HeightRequest = 100,
            };

            relativeLayout.Children.Add(
                MyLable,
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
                                                            return parent.Height*.15;
                })
                );

            relativeLayout.Children.Add(
                face,
                Constraint.RelativeToParent((parent) => {
                                                            return ((parent.Width/2) - (parent.Width*.25/2));
                }),
                Constraint.RelativeToParent((parent) => {
                                                            return ((55 + backgroundImage.Height) - (parent.Width*.25/2));
                }),
                Constraint.RelativeToParent((parent) => {
                                                            return parent.Width*.25;
                }),
                Constraint.RelativeToParent((parent) => {
                                                            return parent.Width*.25;
                })
                );

            relativeLayout.Children.Add(
                User,
                Constraint.RelativeToParent((parent) => {
                                                            return ((parent.Width/2) - (User.Width/2));
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return (55 + backgroundImage.Height + parent.Width*.20/2 +
                            15);
                })
                //    Constraint.Constant(70),
                //   Constraint.Constant(28)
                );

            relativeLayout.Children.Add(
                RelationG,
                Constraint.RelativeToParent((parent) => {
                                                            return ((parent.Width/2) - 35);
                }),
                Constraint.RelativeToView(User, (parent, View) => {
                                                                      return (View.Y + View.Height + 15);
                })
                );

            relativeLayout.Children.Add(
                Relation,
                Constraint.RelativeToView(RelationG, (parent, View) => {
                                                                           return (View.X + 29);
                }),
                Constraint.RelativeToView(RelationG, (parent, View) =>
                {
                    return (View.Y + View.Height/2 -
                            Relation.Height/2 - 3);
                })
                );

            relativeLayout.Children.Add(
                SexImage,
                Constraint.RelativeToParent((parent) => {
                                                            return ((parent.Width/2) - 35 - 10 - 50);
                }),
                Constraint.RelativeToView(User, (parent, View) => {
                                                                      return (View.Y + View.Height + 15);
                })
                );

            relativeLayout.Children.Add(
                Age,
                Constraint.RelativeToView(SexImage, (parent, View) => {
                                                                          return (View.X + 25);
                }),
                Constraint.RelativeToView(SexImage, (parent, View) =>
                {
                    return (View.Y + View.Height/2 - Age.Height/2 -
                            3);
                })
                );

            relativeLayout.Children.Add(
                HeartG,
                Constraint.RelativeToParent((parent) => {
                                                            return ((parent.Width/2) + 35 + 10);
                }),
                Constraint.RelativeToView(User, (parent, View) => {
                                                                      return (View.Y + View.Height + 15);
                })
                );

            relativeLayout.Children.Add(
                HeartDU,
                Constraint.RelativeToView(HeartG, (parent, View) => {
                                                                        return (View.X + 29);
                }),
                Constraint.RelativeToView(HeartG, (parent, View) =>
                {
                    return (View.Y + View.Height/2 -
                            HeartDU.Height/2 - 3);
                })
                );

            relativeLayout.Children.Add(
                Edit,
                Constraint.RelativeToView(HeartG, (parent, View) => {
                                                                        return (View.X + View.Width);
                }),
                Constraint.RelativeToView(HeartG, (parent, View) => {
                                                                        return (View.Y - Edit.Height);
                })
                );

            relativeLayout.Children.Add(
                table,
                Constraint.Constant(0),
                Constraint.RelativeToView(SexImage, (parent, View) => {
                                                                          return (View.Y + View.Height);
                })
                );

            relativeLayout.Children.Add(
                WeChat,
                Constraint.RelativeToParent((parent) => {
                                                            return ((parent.Width/2) - 50);
                }),
                Constraint.RelativeToView(table, (parent, View) => {
                                                                       return (View.Y + 250);
                })
                );

            relativeLayout.Children.Add(
                Call,
                Constraint.RelativeToView(WeChat, (parent, View) => {
                                                                        return (View.X - 100 - 15);
                }),
                Constraint.RelativeToView(table, (parent, View) => {
                                                                       return (View.Y + 250);
                })
                );

            relativeLayout.Children.Add(
                SendMess,
                Constraint.RelativeToView(WeChat, (parent, View) => {
                                                                        return (View.X + 100 + 15);
                }),
                Constraint.RelativeToView(table, (parent, View) => {
                                                                       return (View.Y + 250);
                })
                );

            Content = relativeLayout;

            
            MessagingCenter.Subscribe<ChangeRelation, string>(this, "RELATION", (sender, arg) =>
            {
                Relation.Text = arg;
                ViewModel._friendInfo.Relationship = arg;
            });
            MessagingCenter.Subscribe<ChangeRelation, string>(this, "HEART", (sender, arg) =>
            {
                switch (arg)
                {
                    case "黑名单":
                        HeartG.Source = "@drawble/heimingdan";
                        HeartDU.Text = "";
                        break;
                    default:
                        HeartG.Source = "@drawble/heartground";
                        HeartDU.Text = arg;
                        break;
                }
                ViewModel._friendInfo.Heart = arg;
            });
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }


    public class HospitalCell : ViewCell
    {
        public HospitalCell()
        {
            var image = new Image
            {
                HeightRequest = 24,
                WidthRequest = 24,
                Source = "@drawable/hospital",
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            };

            var lable = new Label()
            {
                Text = "医院",
                TextColor = Color.Silver,
                FontSize = 18,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            var HospitalLable = new Label()
            {
                TextColor = Color.Silver,
                FontSize = 18,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            };
            HospitalLable.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Hospital);

            var layout = new StackLayout()
            {
                Padding = new Thickness(25, 0, 25, 0),
                Spacing = 10,
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                Children =
                {
                    image,
                    lable,
                    HospitalLable
                }
            };
            View = layout;
        }
    }

    public class JobCell : ViewCell
    {
        public JobCell()
        {
            var image = new Image
            {
                HeightRequest = 24,
                WidthRequest = 24,
                Source = "@drawable/job",
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            };

            var lable = new Label()
            {
                Text = "职称",
                TextColor = Color.Silver,
                FontSize = 18,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            var JobLable = new Label()
            {
                TextColor = Color.Silver,
                FontSize = 18,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            };
            JobLable.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Job);

            var layout = new StackLayout()
            {
                Padding = new Thickness(25, 0, 25, 0),
                Spacing = 10,
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                Children =
                {
                    image,
                    lable,
                    JobLable
                }
            };
            View = layout;
        }
    }

    public class GoodatCell : ViewCell
    {
        public GoodatCell()
        {
            var image = new Image
            {
                HeightRequest = 24,
                WidthRequest = 24,
                Source = "@drawable/goodat",
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            };

            var lable = new Label()
            {
                Text = "擅长领域",
                TextColor = Color.Silver,
                FontSize = 18,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            var GoodatLable = new Label()
            {
                TextColor = Color.Silver,
                FontSize = 18,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            };
            GoodatLable.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Goodat);

            var layout = new StackLayout()
            {
                Padding = new Thickness(25, 0, 25, 0),
                Spacing = 10,
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                Children =
                {
                    image,
                    lable,
                    GoodatLable
                }
            };
            View = layout;
        }
    }

    public class ProfessionCell : ViewCell
    {
        public ProfessionCell()
        {
            var image = new Image
            {
                HeightRequest = 24,
                WidthRequest = 24,
                Source = "@drawable/profession",
                Aspect = Aspect.Fill,
                HorizontalOptions = LayoutOptions.Start,
                VerticalOptions = LayoutOptions.Center
            };

            var lable = new Label()
            {
                Text = "科室",
                FontSize = 18,
                TextColor = Color.Silver,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center
            };

            var ProfessionLabel = new Label()
            {
                TextColor = Color.Silver,
                FontSize = 18,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.End,
                VerticalOptions = LayoutOptions.Center
            };
            ProfessionLabel.SetBinding<FriendDetailViewModel>(Label.TextProperty, vm => vm._friendInfo.Profession);

            var layout = new StackLayout()
            {
                Padding = new Thickness(25, 0, 25, 0),
                Spacing = 10,
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.White,
                Children =
                {
                    image,
                    lable,
                    ProfessionLabel
                }
            };
            View = layout;
        }
    }
}