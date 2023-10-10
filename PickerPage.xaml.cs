﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Linq;
namespace XF_PickerExample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerPage : ContentPage
    {
        public PickerPage()
        {
            InitializeComponent();
            var zone = GetZone();
            pickerZone.ItemsSource = zone;


            


        }

        private List<Zone> GetZone()
        {
            return new List<Zone>
            {
                new Zone{Id=1,Name="Qassim"},
                new Zone{Id=2,Name="Riyadh"},
                new Zone{Id=3,Name="Makkah"},
            };
        }
        private List<City> GetCIty()
        {
            return new List<City>
            {
                new City{Id=1,Name="Buraydah", ZId=1},
                new City{Id=2,Name="Unizah", ZId=1},
                new City{Id=3,Name="Alrass", ZId=1},
               
                new City{Id=7,Name="Riyadh", ZId=2},
                new City{Id=8,Name="Deraih", ZId=2},
                new City{Id=9,Name="Mjmah", ZId=2},
                new City{Id=10,Name="Romah", ZId=2},

                new City{Id=4,Name="Jeddah", ZId=3},
                new City{Id=5,Name="Makkah", ZId=3},
                new City{Id=6,Name="Taif", ZId=3}
            };
        }


        List<City> myList;
        private void pickerZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerZone.SelectedIndex == -1)
            {
                DisplayAlert("Zone", "Please select", "Ok");
                return;
            }
            Zone zone = pickerZone.SelectedItem as Zone;


            var list = GetCIty();
            myList = list.Where(i => i.ZId == zone.Id).ToList();
            pickerCity.ItemsSource = myList;
        }

        private void pickerCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pickerZone.SelectedIndex == -1)
            {
                DisplayAlert("City", "Please select", "Ok");
                return;
            }
            City city = pickerCity.SelectedItem as City;
        }


    }
}