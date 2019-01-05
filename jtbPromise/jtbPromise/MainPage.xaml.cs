﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace jtbPromise
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }
        async void BtnCreateOffLine_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MakeDocPage(), false);
            Navigation.RemovePage(this);
        }

        async void BtnSearch_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SearchDocPage(), false);
        }


    }
}
