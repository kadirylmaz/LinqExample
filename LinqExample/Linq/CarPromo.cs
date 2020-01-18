using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class CarPromo
    {
        public string Make { get; set; }
        public string Slogan { get; set; }

        public CarPromo(string make, string slogan)
        {
            this.Make = make;
            this.Slogan = slogan;
        }

        public static List<CarPromo> GetPromos()
        {
            return new List<CarPromo>
                 {
                     new CarPromo("BMW", "The Ultimate driving machine"),
                     new CarPromo("Ford", "Go Further"),
                     new CarPromo("Audi","Truth in Engineering"),
                     new CarPromo("Acura", "Precision Crafted Performance"),
                     new CarPromo("Lexus", "The Relentless Pursuit of Perfection"),
                     new CarPromo("Mercedes Benz", "The best or nothing")
                 };
        }
    }
}
