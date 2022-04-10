﻿using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Hierarchical.MVVM.Services;
using Hierarchical.MVVM.ViewModels;

namespace Hierarchical.MVVM.Views
{
    public partial class Content3Page : ContentPage
    {
        Content3ViewModel ViewModel => BindingContext as Content3ViewModel;

        public Content3Page()
        {
            InitializeComponent();

            BindingContext = new Content3ViewModel(DependencyService.Get<INaviService>());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Initialize ViewModel
            ViewModel?.Init();
        }
    }
}