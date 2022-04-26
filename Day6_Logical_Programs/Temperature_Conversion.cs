using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programs
{
    internal class Temperature_Conversion
    {
        public void TemperatureConversion(int Num4)
        {

            double c, f;

            switch (Num4)
            {
                case 0:
                    Console.WriteLine("Enter any Temperature value in celcius");
                    c = Convert.ToDouble(Console.ReadLine());
                    f = c * 9 / 5 + 32;
                    Console.WriteLine("Temperature in FAHRENHEIT " + f);
                    break;
                case 1:
                    Console.WriteLine("Enter any Temperature value in Fahrenheit");
                    f = Convert.ToDouble(Console.ReadLine());
                    c = (f - 32) * 5 / 9;
                    Console.WriteLine("Temperature in CELCIUS " + c);
                    break;
            }
        }
    }
}
