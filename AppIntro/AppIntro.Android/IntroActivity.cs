using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Github.Appintro;
using Com.Github.Appintro.Model;
namespace AppIntro.Droid
{
    [Activity(Theme = "@style/MainTheme")]
    public class IntroActivity : AppIntro2
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            AddSlide(AppIntroFragment.NewInstance(
                 "Welcome!",
                 "This is a demo of the AppIntro library, using the second layout.",
                 imageDrawable: Resource.Mipmap.ic_slide1,
                 backgroundDrawable: Resource.Drawable.back_slide1
                // titleTypefaceFontRes: Resource.Font.lato,
                 //descriptionTypefaceFontRes: Resource.Font.lato
             ));

            AddSlide(AppIntroFragment.NewInstance(new SliderPage(
                "Gradients!",
                "This text is written on a gradient background",
                imageDrawable: Resource.Mipmap.ic_slide2,
                backgroundDrawable: Resource.Drawable.back_slide2
                //titleTypeface: "OpenSans-Light.ttf",
               // descriptionTypeface: "OpenSans-Light.ttf"
            )));

            AddSlide(AppIntroFragment.NewInstance(
                "Simple, yet Customizable",
                "The library offers a lot of customization, while keeping it simple for those that like simple.",
                imageDrawable: Resource.Mipmap.ic_slide3,
                backgroundDrawable: Resource.Drawable.back_slide3
               // ,titleTypefaceFontRes: Resource.Font.opensans_regular,
               // descriptionTypefaceFontRes: Resource.Font.opensans_regular
            ));

            AddSlide(AppIntroFragment.NewInstance(
                "Explore",
                "Feel free to explore the rest of the library demo!",
                imageDrawable: Resource.Mipmap.ic_slide4,
                backgroundDrawable: Resource.Drawable.back_slide4
            ));

            AddSlide(AppIntroFragment.NewInstance(
                ":)",
                "...gradients are awesome!",
                imageDrawable: Resource.Mipmap.icon,
                backgroundDrawable: Resource.Drawable.back_slide5
            ));
            //do you can implement this 
            //SystemBackButtonLocked = true;
            //SkipButtonEnabled = true;
            //SetSkipText("PULAR");
            //SetDoneText("FINALIZAR");
            //SetImmersiveMode();
            SetTransformer(new AppIntroPageTransformerType.Parallax());
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
        }

        protected override void OnSkipPressed(AndroidX.Fragment.App.Fragment currentFragment)
        {
            AppSettings.AppTutorialInit = true;

            base.OnSkipPressed(currentFragment);

            //force try
            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }

        protected override void OnDonePressed(AndroidX.Fragment.App.Fragment currentFragment)
        {
            AppSettings.AppTutorialInit = true;

            base.OnDonePressed(currentFragment);
            var intent = new Intent(this, typeof(MainActivity));
            StartActivity(intent);
            Finish();
        }
    }
}