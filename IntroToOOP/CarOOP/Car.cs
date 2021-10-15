using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOOP
{
    class Car
    {
        public string make;
        public string model;
        public string color;
        public int year;


        public Car()
        {
            make = "N/A";
            model = "N/A";
            color = "N/A";
            year = 0;
        }
        // CONSTRUCTOR
        public Car(string _make, string _model, string _color, int _year)
        {
            make = _make;
            model = _model;
            color = _color;
            year = _year;

        }

        public string GetCarInformation()
        {
            return $"Make: {make}\nModel: {model}\nYear: {year}\nColor: {color}";
        }
    }
}
