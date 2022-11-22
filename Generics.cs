using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Fountation
{
    internal class Generics
    {
        public static void Go()
        {
            int first = 20;
            int second = 40;

            Swap(ref first, ref second);
            //Console.WriteLine("First: {0}", first);
            //Console.WriteLine("Second: {0}", second);

            float food = 3.5f;
            float sleep = 4.7f;

            Swap<float>(ref food, ref sleep);
            //Console.WriteLine("Food: {0}", food);
            //Console.WriteLine("Sleep: {0}", sleep);

            //GetConsoleNumber<int>("Enter int: ", 1, 10);

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }

        class Stack<T>
        {
            int index = 0;
            T[] elements = new T[100];

            //add data to stack
            public void Push(T element)
            {
                elements[index++] = element;
            }

            public T Pop()
            {
                if(index > 0)
                {
                    return elements[--index];
                }
                return default;
            }
        }

        public static T GetConsoleNumber<T>(string message, double min, double max)
        {
            bool success = false;
            double dbTypedValue;

            do
            {
                Console.WriteLine(message);
                success = double.TryParse(Console.ReadLine(), out dbTypedValue);
                success = success & dbTypedValue >= min && dbTypedValue <= max;

                if (!success)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Must be between {0} and {1} and a valid number.", min, max);
                }

            } while (!success);

            return (T)Convert.ChangeType(dbTypedValue, typeof(T));
        }

        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }

        static void Swap<G>(ref G first, ref G second)
        {
            G temp = first;
            first = second;
            second = temp;
        }
    }
}
