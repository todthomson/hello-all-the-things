﻿using MonoTouch.UIKit;

namespace Hello.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        private static void Main(string[] args)
        {
            // If you want to use a different Application Delegate class from "AppDelegate" you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
