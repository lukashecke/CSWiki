using System;
using System.Collections.Generic;
using System.Text;
using CSWiki.View;
using System.Windows.Input;
using Xamarin.Forms;

namespace CSWiki.ViewModel
{
    class SleepingPageViewModel : ViewModelBase
    {
        public ICommand HomeCommand { get; private set; }

        public SleepingPageViewModel ()
        {
            this.HomeCommand = new Command(CommandHome);

        }
        public async void CommandHome (object param)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
