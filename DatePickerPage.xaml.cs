﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF_PickerExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DatePickerPage : ContentPage
    {
        public DatePickerPage()
        {
            InitializeComponent();

        }


        private void btnShow_Clicked(object sender, EventArgs e)
        {
            DateTime date = datePicker.Date;
            var time = timePicker.Time;

            string datetime = "Date: " + date.ToString("d") + " time is: " + time.ToString();
            lblResult.Text = datetime;
        }


    }
}