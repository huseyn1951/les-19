using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Months month1 = Months.Dekabr;
            Console.WriteLine($"{month1} is {month1.FindSeason()} season");

            Months month2 = Months.Oktyabr;
            Console.WriteLine($"{month2} is {month2.FindSeason()} season");

        }
    }
}
