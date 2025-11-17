using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP17_4
{
    struct Weather
    {
        public string City { get; set; }
        public double? Temperature { get; set; }

        public override string ToString()
        {
            return $"{City}: {(Temperature.HasValue ? Temperature.Value + "°C" : "Нет данных")}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var w1 = new Weather { City = "Питер", Temperature = 20.5 };
            var w2 = new Weather { City = "Екатеринбург", Temperature = null };

            Console.WriteLine(w1);
            Console.WriteLine(w2);
            Console.WriteLine(w2.Temperature ?? -99);
        }
    } 
}