using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ListViewDU.Views;

namespace ListViewDU
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ObjectListPage());
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
