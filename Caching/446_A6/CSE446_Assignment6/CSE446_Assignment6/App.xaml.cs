﻿using CSE446_Assignment6.Services;
using CSE446_Assignment6.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CSE446_Assignment6
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
