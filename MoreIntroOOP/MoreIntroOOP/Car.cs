using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreIntroOOP
{
    class Car
    {

        // variables or data fields must be private at all times
        private string make;
        private string model;
        private string color;
        private int year;

        // properties
        public string Make {set; get;}
        public string Color { 
            set
            {
                if (value != "")
                    color = value;
                else
                    color = "N/A";
            } 
            get
            {
                return color;
            }
        }

        public string Model { set; get; }

        public int Year 
        { 
            set 
            {
                if (value >= 0)
                    year = value;
            }
            get
            {
                return year;
            }
        }

        // overloaded constructers

        // called default constructor
        public Car()
        {
            make = "N/A";
            model = "N/A";
            color = "N/A";
            year = 0;
        }
        // 5-parameterized CONSTRUCTOR
        public Car(string _make, string _model, string color, int _year)
        {
            make = _make;
            model = _model;
            //color = _color;
            Color = color;
            year = _year;

        }

        //public void SetColor(string _color)
        //{
        //    if (_color != "")
        //        color = _color;
        //    else
        //        color = "N/A";
        //}

        //public string GetColor()
        //{
        //    return color;
        //}

        public override string ToString()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}\nColor: {Color}";
        }

        public string GetCarInformation()
        {
            return $"Make: {make}\nModel: {model}\nYear: {year}\nColor: {color}";
        }
    }
}
