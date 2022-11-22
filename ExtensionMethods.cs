using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountation
{
    internal class ExtensionMethods
    {
        public static void Go()
        {
            string strMsg = "I want to go home";

            Console.WriteLine("Size of {0} is {1}", strMsg, strMsg.Length);

            Console.WriteLine("Is {0} first letter capital? {1}", strMsg, strMsg.IsFirstCap());

            Console.WriteLine(strMsg.AppendToEnd( " and sleep."));
        }
    }

    public static class StringHelper
    {
        public static bool IsFirstCap(this string strIncoming)
        {
            return char.IsUpper(strIncoming[0]);
        }

        public static string AppendToEnd(this string incoming, string append)
        {
            return incoming + append;
        }
    }
}
