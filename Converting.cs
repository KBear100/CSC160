using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountation
{
    internal class Converting
    {
        public static void DoIt()
        {
            //Casting and Converting

            //Implicit Conversion
            int intNum = 132435;
            long lngNum = intNum;
            var c = 'c';
            Console.WriteLine("Var Type: " + c.GetType());
            Console.WriteLine();

            //Explicit Conversion
            //if a conversion can't be made without risk of losing informaiton, the compiler requires you to perform an explicit conversion. (cast)
            //cast tells compiler you are aware of the risk when converting, that it might fail at run time.

            double d = 123.4;
            int i;
            i = (int)d;
            Console.WriteLine(i);
            Console.WriteLine();

            string strNum = "5";
            int intResult = 0;
            intResult = int.Parse(strNum);
            Console.WriteLine("Parse: " + intResult + " " + intResult.GetType());
            bool bSuccess = int.TryParse(strNum, out intResult);
            Console.WriteLine(strNum + " converts into int? " + bSuccess);
            Console.WriteLine();

            Console.WriteLine(isNumeric("no"));
            Console.WriteLine();
        }

        /// <summary>
        /// Tests if a string is a number
        /// </summary>
        /// <param name="strNumber">The stirng which you wish to test</param>
        /// <returns>true or false</returns>
        public static bool isNumeric(string strNumber)
        {
            double dbIsNumber;
            return double.TryParse(strNumber, out dbIsNumber);
        }
    }
}
