using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Select
            //var query = from car in Car.getInventory()
            //            select car;

            //Where

            //var BmwList = from car in Car.getInventory()
            //            where car.Make == "BMW"
            //            select new
            //            {
            //                car.Make,
            //                car.Model
            //            };
            //query.ToList().ForEach(x => Console.WriteLine());
            //foreach (var bmw in BmwList)
            //{
            //    Console.Write("Make :" +  bmw.Make);
            //    Console.Write(" Model :" +  bmw.Model);
            //}

            //Order By

            //var orderByYearCars = from car in Car.getInventory()
            //                      orderby car.Year descending
            //                      select car;

            //foreach (var car in orderByYearCars)
            //{
            //    Console.WriteLine(car.Make + "-" + car.Model + "-" + car.Year);
            //}

            //Group By

            //var groupByYearCars = from car in Car.getInventory()
            //                      group car by car.Year;

            //groupByYearCars.ToList().ForEach(x =>
            //{
            //    Console.WriteLine(x.Key);
            //    x.ToList().ForEach(car =>
            //    {
            //        Console.WriteLine(car);
            //    });
            //});

            //Inner Join

            var vehiclePromos = from car in Car.getInventory()
                                join p in CarPromo.GetPromos()
                                on car.Make equals p.Make
                                select new
                                {
                                    car.Make,
                                    car.Model,
                                    p.Slogan
                                };

            vehiclePromos.ToList().ForEach(x =>
            {
                Console.WriteLine($"{x.Make} {x.Model} '{x.Slogan}'");
            });


            Console.ReadLine();
        }
    }
}
