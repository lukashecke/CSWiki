using CSWiki.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CSWiki.ViewModel
{
    class ListingPageViewModel : ViewModelBase
    {
        Data data = new Data();

        public ListingPageViewModel ()
        {
            this.queries = new ObservableCollection<Model.Model>(data.Database.Tables["DataTable"].Select().ToList().Select(r => new Model.Model(r["query"] as string, r["description"] as string, r["example"] as string, r["information"] as string)));

            this.SelectCommand = new Command(CommandSelect);
        }

        private ObservableCollection<Model.Model> queries;
        public ObservableCollection<Model.Model> Queries
        {
            get
            {
                if (this.queries == null)
                {
                    this.queries = new ObservableCollection<Model.Model>();
                }
                return this.queries;
            }
        }

        public ICommand SelectCommand { get; private set; }

        public async void CommandSelect (object param)
        {


        }
    }
}
