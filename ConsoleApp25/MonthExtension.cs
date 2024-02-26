using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    public static class MonthExtension
    {
        public static string FindSeason(this Months month)
        {
            switch (month)
            {
                case Months.Dekabr:
                case Months.Yanvar:       
                case Months.Fevral:
                    return "winter";


                case Months.Mart:        
                case Months.Aprel:      
                case Months.May:
                 return "spring";

                case Months.İyun: 
                case Months.İyul:
                case Months.Avqust:
                    return "summer";


                case Months.Sentyabr: 
                case Months.Oktyabr:
                case Months.Noyabr:
                    return "autumn";
                    
                default:return "incorrect month";
                    break;
            }

        }
    }
}
