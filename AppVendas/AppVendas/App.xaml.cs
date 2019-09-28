﻿using AppVendas.Services;
using AppVendas.Views;
using System.Globalization;
using Xamarin.Forms;

namespace AppVendas
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
            DependencyService.Register<MockDataStore>();
            DependencyService.Register<MockDataStoreClientes>();

            MainPage = new MainPage();
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