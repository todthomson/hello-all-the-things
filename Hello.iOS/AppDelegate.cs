﻿using MonoTouch.Foundation;
using MonoTouch.UIKit;
using Xamarin.Forms;

namespace Hello.iOS
{
    // The UIApplicationDelegate for the application.
    // This class is responsible for launching the User Interface of the application,
    // as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        private UIWindow window;

        // This method is invoked when the application has loaded and is ready to run.
        // In this method you should instantiate the window,
        // load the UI into it and then make the window visible.
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();
            window = new UIWindow(UIScreen.MainScreen.Bounds) { RootViewController = App.GetMainPage().CreateViewController() };
            window.MakeKeyAndVisible();
            return true;
        }
    }
}
