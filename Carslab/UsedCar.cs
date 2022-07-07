using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carslab
{
    internal class UsedCar : Car
    {
        //properties
        public double Mileage { get; set; }
        public UsedCar(string _make, string _model, int _year, decimal _price, double _mileage)
        {
            Make = _make;
            Model = _model;
            Year = _year;
            Price = _price;
            Mileage = _mileage;
        }
        public override string ToString()
        {
            return base.ToString() + $"It has {Mileage} miles";
            //return$"{Make} is a {Model} from the year {Year} and costs ${Price}.  It has {Mileage} miles.";
        }
    }
}
