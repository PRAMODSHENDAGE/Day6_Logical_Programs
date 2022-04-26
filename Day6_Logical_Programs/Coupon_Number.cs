using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Logical_Programs
{
    internal class Coupon_Number
    {
        public static void Coupon()
        {
            int Number;
            Console.WriteLine("Enter your Number");
            Number = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int Num = random.Next(0, Number);
            Console.WriteLine(Num);
        }
    }
}
