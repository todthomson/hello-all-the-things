using Android.App;
using Android.Content.PM;
using Android.OS;
using Hello.XamarinForms;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace Hello.Droid
{
    [Activity(Label = "Hello.XamarinForms", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : AndroidActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            Forms.Init(this, bundle);
            SetPage(App.GetMainPage());
        }
    }
}
