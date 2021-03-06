﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace FormsBugs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tabbedPage = new FormsBugs.MainPage();

            tabbedPage.Children.Add(new Page1());
            tabbedPage.Children.Add(new Page2());
            tabbedPage.Children.Add(new Page3());


            MainPage = tabbedPage;
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
