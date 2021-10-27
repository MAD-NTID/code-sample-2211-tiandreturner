using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePractical2_Turner
{
    class Alien
    {




        private string name;

        public string Name
        {
            get { return name; }
            set {
                if (value == "" || value.Length == 0)
                    name = "Unidentified";
                else
                    name = value;
            }
        }

        private string date;

        public string Date
        {
            get { return date; }
            set
            {
                if (value == "" || value.Length == 0)
                    date = "Not Provided";
                else
                    date = value;
            }
        }

        private string location;

        public string Location
        {
            get { return location; }
            set
            {
                if (value == "" || value.Length == 0)
                    location = "Not Provided";
                else
                    location = value;
            }
        }

        public Alien()
        {
            Name = "Unidentified";
            Date = "Not Provided";
            Location = "N/A";
        }

        public Alien(string name, string date, string location)
        {
            Name = name;
            Date = date;
            Location = location;
        }

        public override string ToString()
        {
            return $"{Name,-12}{Date,12} {Location}";
        }
    }
}
