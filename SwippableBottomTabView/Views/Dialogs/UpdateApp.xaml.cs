﻿using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.Support.V7.Widget;
using Xamarin.Forms;

namespace IFrame.Views.Dialogs
{
    public partial class UpdateApp : PopupPage
    {
        public UpdateApp()
        {
            InitializeComponent();
            progressbar.Progress = 0.5;
        }

        private void OnNotButton(object sender, EventArgs e)
        {
            Navigation.PopPopupAsync();
        }
    }
}

