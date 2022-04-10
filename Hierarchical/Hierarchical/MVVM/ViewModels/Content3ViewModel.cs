using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Hierarchical.MVVM.Services;

namespace Hierarchical.MVVM.ViewModels
{
    public class Content3ViewModel : BaseViewModel
    {
        public Command BackPage => new Command(async () => await NavigationService.GoBack());

        public Content3ViewModel(INaviService naviService) : base(naviService)
        {
            //Code for creating the ViewModel
        }

        public override void Init()
        {
            //Code for initialize the ViewModel
        }

    }
}
