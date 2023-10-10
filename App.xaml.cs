using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_PickerExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            //MainPage = new PickerPage();

            MainPage = new WebViewPage();

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
