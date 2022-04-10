using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Hierarchical.MVVM.Services;

namespace Hierarchical.MVVM.ViewModels
{
    public class Content1ViewModel : BaseViewModel
    {
        public Command NextPage => new Command(async () => await NavigationService.NavigateTo<Content2ViewModel>());
        public Command BackPage => new Command(async () => await NavigationService.GoBack());

        public Content1ViewModel(INaviService naviService) : base(naviService)
        {
            //Code for creating the ViewModel
        }

        public override void Init()
        {
            //Code for initialize the ViewModel
        }

    }
}
