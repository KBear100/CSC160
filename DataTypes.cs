using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountation
{
    internal class DataTypes
    {
        public static void Execute()
        {
            short shtNum = 32727; //16 bits
            int intNum = 20; //32 bits
            uint uintNum = 50; //32 bits
            long lngNum = 9999; //64 bits
            float fltNum = 10.5f; //4 bytes
            double dblNum = 500.4; //8 bytes
            decimal decNum = 20.20m; //16 bytes

            Console.WriteLine("Short min: " + short.MinValue);
            Console.WriteLine("Short max: " + short.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Int min: " + int.MinValue);
            Console.WriteLine("Int max: " + int.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Uint min: " + uint.MinValue);
            Console.WriteLine("Uint max: " + uint.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Long min: " + long.MinValue);
            Console.WriteLine("Long max: " + long.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Float min: " + float.MinValue);
            Console.WriteLine("Float max: " + float.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Double min: " + double.MinValue);
            Console.WriteLine("Double max: " + double.MaxValue);
            Console.WriteLine();
            Console.WriteLine("Decimal min: " + decimal.MinValue);
            Console.WriteLine("Decimal max: " + decimal.MaxValue);
            Console.WriteLine();

            char c = 'A';
            Console.WriteLine("Char is: " + c);
            Console.WriteLine("Is Digit: " + char.IsDigit(c));
            Console.WriteLine("Is Letter: " + char.IsLetter(c));

            string str = "I want sleep.";
            Console.WriteLine();
        }
    }
}
