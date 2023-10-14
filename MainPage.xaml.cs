using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XF_PickerExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            _PickerPage.Clicked += (s, e) => Navigation.PushAsync(new PickerPage());
            _DatePickerPage.Clicked += (s, e) => Navigation.PushAsync(new DatePickerPage());
            _WebViewPage.Clicked += (s, e) => Navigation.PushAsync(new WebViewPage());
            _TabbedPage.Clicked += (s, e) => Navigation.PushAsync(new TabbedPage1());
            _MediaPicker.Clicked += (s, e) => Navigation.PushAsync(new MediaPickerPage());
        }
    }
}
