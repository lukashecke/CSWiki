using System;
using System.Collections.Generic;
using System.Text;

namespace CSWiki.ViewModel
{
    class EntryPageViewModel : ViewModelBase
    {
        public EntryPageViewModel (object model)
        {
            this.Model = model;
        }

        private object model;
        public object Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                this.model = value;
                this.OnPropertyChanged("Model");
            }
        }
    }
}
