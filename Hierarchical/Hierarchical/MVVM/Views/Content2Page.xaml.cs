using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Hierarchical.MVVM.Services;
using Hierarchical.MVVM.ViewModels;

namespace Hierarchical.MVVM.Views
{
    public partial class Content2Page : ContentPage
    {
        Content2ViewModel ViewModel => BindingContext as Content2ViewModel;

        public Content2Page()
        {
            InitializeComponent();

            BindingContext = new Content2ViewModel(DependencyService.Get<INaviService>());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // Initialize ViewModel
            ViewModel?.Init();
        }
    }
}