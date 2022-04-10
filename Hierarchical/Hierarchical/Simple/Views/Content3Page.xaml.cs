using System;
using Xamarin.Forms;

namespace Hierarchical.Simple.Views
{
    public partial class Content3Page : ContentPage
    {
        public Content3Page()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_Back(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }
    }
}