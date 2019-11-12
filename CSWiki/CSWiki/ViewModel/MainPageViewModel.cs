using CSWiki.Model;
using CSWiki.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CSWiki.ViewModel
{
    class MainPageViewModel : ViewModelBase
    {
        private String searchText;
        public String SearchText
        {
            get
            {
                return this.searchText;
            }
            set
            {
                this.searchText = value;
                this.OnPropertyChanged("SearchText");
            }
        }
        public String FarbText
        {
            get
            {
                return HexConverter(Farbe);
            }
        }

        private Color farbe;
        public Color Farbe
        {
            get
            {
                return this.farbe;
            }
            set
            {
                this.farbe = value;
                this.OnPropertyChanged("Farbe");
                this.OnPropertyChanged("FarbText");
            }
        }

        Data data = new Data();

        public MainPageViewModel ()
        {

            this.models = new ObservableCollection<Model.Model>(data.Database.Tables["DataTable"].Select().ToList().Select(r =>
       new Model.Model(r["query"] as string, r["description"] as string, r["example"] as string, r["information"] as string)));

            this.ListCommand = new Command(CommandList);
            this.PictureCommand = new Command(CommandPicture);
        }

        private ObservableCollection<Model.Model> models;
        public ObservableCollection<Model.Model> Models
        {
            get
            {
                if (this.models == null)
                {
                    this.models = new ObservableCollection<Model.Model>();
                }
                return this.models;
            }
        }

        public ICommand ListCommand { get; private set; }


        public async void CommandList (object param)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new ListingPage());
        }


        public ICommand SearchCommand
        {
            get
            {
                return new Command<string>(async (text) =>
                {
                    // The text parameter can now be used for searching.
                    var model = this.Models.Where(element => element.query.ToUpper() == text.ToUpper()).FirstOrDefault();
                    if (model != null)
                        await Application.Current.MainPage.Navigation.PushAsync(new EntryPage(model));
                    // Empty SearchBar after the searchrequest
                    this.SearchText = String.Empty;
                });
            }

        }

        public ICommand ColorCommand
        {
            get
            {
                return new Command(() =>
                {
                    this.Farbe = Color.FromHex(RandomHex());
                });
            }
        }

        public ICommand PictureCommand { get; private set; }
        public async void CommandPicture (object param)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SleepingPage());
        }


        private static String HexConverter (System.Drawing.Color c)
        {
            String rtn = String.Empty;
            try
            {
                rtn = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            }
            catch (Exception ex)
            {
                //doing nothing
            }

            return rtn;
        }

        private String RandomHex ()
        {
            string s = String.Empty;
            Random random = new Random();
            int i = 0;
            while (i < 6)
            {

                s += (random.Next(15).ToString("X"));
                i++;
            }
            return s.ToString();

        }

    }

}
