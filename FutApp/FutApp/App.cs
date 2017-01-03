using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FutApp.View;
using Xamarin.Forms;

namespace FutApp
{
    public class App : Application
    {
        public App()
        {
            MainPage = new HomeTabbedPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
