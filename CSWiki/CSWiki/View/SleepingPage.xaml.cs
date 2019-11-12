using CSWiki.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CSWiki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SleepingPage : ContentPage
    {
        public SleepingPage ()
        {
            InitializeComponent();
            BindingContext = new SleepingPageViewModel();
        }

    }
}