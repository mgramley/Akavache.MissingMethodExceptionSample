using MissingMethodExceptionSample.Services;
using MissingMethodExceptionSample.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MissingMethodExceptionSample
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            Akavache.Registrations.Start("MissingMethodExceptionSample");

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
