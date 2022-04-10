using System;
using Xamarin.Forms;

namespace Hierarchical.Simple.Views
{
    public partial class Content2Page : ContentPage
    {
        public Content2Page()
        {
            InitializeComponent();
        }
        private async void Button_Clicked_Next(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Content3Page());
        }

        private async void Button_Clicked_Back(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

    }
}