using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePractical2 {
    /*
     * Class:       Alien
     * Author:      Prof. R.
     * Date:        23 Oct 2021
     * Summary:     Holds and manages data for a single alien sighting
     */
    class Alien {
        private string name;
        public string Name {
            get {
                return name;
            }
            set {
                name = string.IsNullOrWhiteSpace(value) ? "Unidentified" : value;
            }
        }

        private string date;
        public string Date {
            get { return date; }
            set {
                date = string.IsNullOrWhiteSpace(value) ? "Not provided" : value;
            }
        }

        private string location;
        public string Location {
            get { return location; }
            set {
                location = string.IsNullOrWhiteSpace(value) ? "N/A" : value;
            }
        }

        private string layout = "{0, -12} {1, 12} {2}";
        public string Layout {
            get { return layout; }
        }

        public Alien() {
            Name = "";
            Date = "";
            Location = "";
        }

        public Alien( string _name, string _date, string _location ) {
            Name = _name;
            Date = _date;
            Location = _location;
        }

        public override string ToString() {
            return string.Format(Layout, Name, Date, Location);
        }

    }
}
