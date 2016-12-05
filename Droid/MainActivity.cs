using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Plugin.Toasts;
using System.Threading;
using Xamarin.Forms;

namespace IFrame.Droid
{
    [Activity(Label = "医连", Icon = "@drawable/icon", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {

        protected override void OnCreate(Bundle bundle)
        {
            
            base.OnCreate(bundle);
            ActionBar.SetIcon(Android.Resource.Color.Transparent);
            
            Forms.Init(this, bundle);
            DependencyService.Register<ToastNotificatorImplementation>(); // Register your dependency
            ToastNotificatorImplementation.Init(this);
            LoadApplication(new App());
        }
    }
    [Activity(Label = "医连", Icon = "@drawable/icon", MainLauncher = true, NoHistory = true, Theme = "@style/Theme.Splash", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Wait for 2 seconds
            Thread.Sleep(100);

            //Moving to next activity
            StartActivity(typeof(MainActivity));
        }
    }
}