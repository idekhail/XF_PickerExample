using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_PickerExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
            _WebView.Source = "http://teatchyourself.com/";
        }
        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            labelLoading.IsVisible = true;
        }
        void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            labelLoading.IsVisible = false;
        }
    }
}