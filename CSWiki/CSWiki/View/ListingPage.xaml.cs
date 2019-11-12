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
	public partial class ListingPage : ContentPage
	{
		public ListingPage ()
		{
			InitializeComponent ();

            BindingContext = new ListingPageViewModel();
		}

        private async void PART_ListView_ItemTapped (object sender, ItemTappedEventArgs e)
        {

            var query = e.Item;
            await Navigation.PushAsync(new EntryPage(query));
        }
    }
}