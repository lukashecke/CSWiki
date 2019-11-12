using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

using CSWiki.ViewModel;

namespace CSWiki
{
    public partial class MainPage : ContentPage
    {
        public MainPage ()
        {
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }
        private void DeviceDisplay_MainDisplayInfoChanged (object sender, DisplayInfoChangedEventArgs e)
        {
            if (e.DisplayInfo.Orientation == DisplayOrientation.Landscape)
            {
                MainGridVertical.IsVisible = false;
                MainGridHorizontal.IsVisible = true;
            }
            else if (e.DisplayInfo.Orientation == DisplayOrientation.Portrait)
            {
                MainGridVertical.IsVisible = true;
                MainGridHorizontal.IsVisible = false;
            }
        }

        private void Button_Pressed (object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
