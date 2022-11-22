using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Fountation
{
    internal class Arrays
    {
        public static void Go()
        {
            int[] myArray1 = new int[3]; // int array, size 3
            myArray1[0] = 55;
            myArray1[1] = 125;
            myArray1.SetValue(23, 2);

            int[] myArray2 = { 1, 2, 3, 4 }; // int array, size 4
            int[] myArray3 = new int[] {1, 2, 3, 4 };

            for(int i = 0; i < myArray1.Length; i++)
            {
                Console.WriteLine(myArray1[i]);
            }

            foreach(int intNum in myArray1)
            {
                Console.WriteLine(intNum);
                break; // exits loop
                //continue; // gets out of current iteration in the loop, ignoring all code after
            }

            string[,] alphabet = new string[2, 2] { { "A", "B" }, { "C", "D" } };

            for (int row = 0; row < alphabet.GetLength(0); row++)
            {
                for(int column = 0; column < alphabet.GetLength(1); column++)
                {
                    Console.Write("{0} ", alphabet[row, column]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            object[] myThings = new object[] { 10, "Bob", 10.5f }; // all types derive from object

            int[] aryNums = { 0, 1, 2, 3, 4, 5, 6 };
            string[] aryStrings = { "5", "7", "2" };
            //WriteArray(aryNums);
            //WriteArray(aryNums[..3]); // range from beginning to end slice, doesn't include last element
            //WriteArray(aryNums[1..4]);
            //WriteArray(aryNums[4..1]);

            //Array.Reverse(aryNums);
            //WriteArray(aryNums);

            //Array.Sort(aryNums);
            //WriteArray(aryNums);

            //Console.WriteLine("Find index of 2: {0}", Array.IndexOf(aryNums, 2));

            //takes in a method or function that returns true/false (predicate)
            //Array.FindAll finds all instances that match the predicate criteria
            Console.WriteLine("All numbers less than 4: ");
            WriteArray(Array.FindAll(aryNums, LessThanFour));

            //jagged array
            //could define row, but columns could be varying sizes
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2, 3, 4 };
            jagged[1] = new int[] { 5, 6, 7 };
            jagged[2] = new int[] { 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};
        }

        static void WriteArray(int[] values)
        {
            //for (int i = 0; i < values.Length; i++)
            //{
            //    Console.WriteLine(values[i]);
            //}
            //Console.WriteLine();

            Console.WriteLine(String.Join(" , ", values));
        }

        static bool LessThanFour(int value)
        {
            return value < 4;
        }
    }
}
