using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CSWiki.Model
{
    public class Model
    {
        public Model (String query, String description, String example, String information)
        {
            this.query = query;
            this.description = description;
            this.example = example;
            this.information = information;
        }

        public String query { get; set; }

        public String description { get; set; }

        public String example { get; set; }

        public String information { get; set; }

        public static implicit operator Model (ObservableCollection<Model> v)
        {
            throw new NotImplementedException();
        }
    }
}
