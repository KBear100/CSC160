using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountation
{
    internal class Strings
    {
        public static void Start()
        {
            //string strName = Console.ReadLine();
            //Console.WriteLine("Hello " + strName); // string concatenation
            //Console.WriteLine("Hello {0} go die!", strName); // string interpolation
            //Console.WriteLine($"Hello again {strName}, please go away."); // string injection

            string strRandom = "Neumont College of Computer Science";
            Console.WriteLine("Length: {0}", strRandom.Length);
            Console.WriteLine("Contains (of): {0}", strRandom.Contains("of"));

            int indexOf = strRandom.IndexOf("of");
            Console.WriteLine("IndexOf position: {0}", indexOf != -1 ? indexOf.ToString() : "Not Found");

            Console.WriteLine("Remove: {0}", strRandom.Remove(indexOf, 3));
            Console.WriteLine(strRandom);

            // string builder
            StringBuilder sb = new StringBuilder();
            sb.Append("I want sleep. ");
            sb.Append("I also want food. ");
            sb.Append("I'm gonna die.");
            Console.WriteLine("StringBuilder: {0}", sb.ToString());
        }
    }
}
