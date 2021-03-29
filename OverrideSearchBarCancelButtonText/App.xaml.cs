using System;
using OverrideSearchBarCancelButtonText.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OverrideSearchBarCancelButtonText
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SearchBarView();
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
