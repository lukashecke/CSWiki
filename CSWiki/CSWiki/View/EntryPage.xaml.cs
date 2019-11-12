using CSWiki.View;
using CSWiki.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CSWiki
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntryPage : TabbedPage
	{
        public EntryPage ()
		{
            InitializeComponent();
        }

        public EntryPage (object model) 
            : this()
        {           
            BindingContext = new EntryPageViewModel(model);
        }
    }
}