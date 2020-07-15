using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace AppIntro.Droid
{
    [Activity(Label = "AppIntro",
    Icon = "@mipmap/icon",
    RoundIcon = "@mipmap/launcher_foreground",
    Theme = "@style/SplashTheme", ScreenOrientation = ScreenOrientation.Unspecified,
    MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            if (AppSettings.AppTutorialInit)
            {
                Xamarin.Essentials.Platform.Init(this, savedInstanceState);
                global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
                var intent = new Intent(this, typeof(MainActivity));
                Window.AddFlags(WindowManagerFlags.Fullscreen);
                intent.AddFlags(ActivityFlags.ClearTop);
                intent.AddFlags(ActivityFlags.SingleTop);
                StartActivity(intent);
                Finish();
            }
            else
            {
                var intent = new Intent(this, typeof(IntroActivity));
                Window.AddFlags(WindowManagerFlags.Fullscreen);
                intent.AddFlags(ActivityFlags.ClearTop);
                intent.AddFlags(ActivityFlags.SingleTop);
                StartActivity(intent);
                Finish();
            }

            // Create your application here
        }
    }
}