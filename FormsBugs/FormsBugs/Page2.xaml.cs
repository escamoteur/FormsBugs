﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FormsBugs
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("OnAppearing Page2");
        }

    }

}
