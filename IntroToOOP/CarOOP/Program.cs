using System;

namespace CarOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars = new Car[5];
            Car tiandre = new Car("Chevrolet", "Avalanche", "Teal", 2006);
            //car.make = "Chevrolet";
            //car.model = "Avalanche";
            //car.year = 2006;
            //car.color = "Teal";
            cars[0] = tiandre;

            Car decker = new Car("Toyota", "Prius", "Red", 2010);
            //decker.make = "Toyota";
            //decker.model = "Prius";
            //decker.year = 2010;
            //decker.color = "Red";
            cars[1] = decker;

            // directly assign to an element of the array after create a new object.
            cars[2] = new Car("Subaru", "Outback", "Tungsten", 2019);

            // OIS (Object Initization Syntax)
            cars[3] = new Car() { make = "Toyota", model = "Camry", color = "White", year = 2009 };


            // Default car
            cars[4] = new Car();

            //for(int index = 0; index < cars.Length; index++)
            //{
            //    Console.WriteLine($"==========Car #{index +1}==========\n{cars[index].GetCarInformation()}");
            //}

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.GetCarInformation()}\n");
            }
        }
    }
}
