using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace AppIntro
{
    public class AppSettings
    {
        public static bool AppTutorialInit {
            get => Preferences.Get(nameof(AppTutorialInit), false);
            set => Preferences.Set(nameof(AppTutorialInit), value);
        }
    }
}
