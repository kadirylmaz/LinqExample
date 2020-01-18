using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int AvailQty { get; set; }
        public double MSRP { get; set; }

        public Car(string make,string model,int year,int availqty,double msrp)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.AvailQty = availqty;
            this.MSRP = msrp;
        }

        public static List<Car> getInventory()
        {
            return new List<Car>
            {
                new Car("BMW","x5",2019,34,61000),
                new Car("BMW","329",2018,84,3700),
                new Car("BMW","x3",2020,252,41000),
                new Car("Ford","F-150",2012,41,10200),
                new Car("Audi","Q5",2019,32,10000),
                new Car("Audi","Q3",2018,12,32200),
                new Car("Acura","RX",2002,14,23333),
            };
        }
    }

    
}
