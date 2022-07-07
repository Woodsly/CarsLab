using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carslab
{
    internal class Car
    {
        //properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public Car()
        {
            Make = "Car";
            Model = "Model";
            Year = 1900;
            Price = 1.00m;
        }
        public Car(string _make, string _model, int _year, decimal _price)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
        }
        public void ToString()
        {
        Console.WriteLine($"{Make} is a {Model} from the year {Year} and costs ${Price}.");
        }

        

        //public void ListCars(List<Car> myList)
        //{
        //    int i = 0;
        //    for (i = 0; i < myList.Count(); i++)
        //    {
        //        myList[i];

        //        //Console.WriteLine($"{myList[i]}");
        //    }
        //    //return i;
        //}

    }
}
