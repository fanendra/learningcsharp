using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication1
{
    public static class LinqToObjects
    {
        static LinqToObjects()
        {
            //Static constructor , only once executed.
            linqFun1();
        }

        // You can't access it outside.
       static void linqFun1()
        {
            List<int> listNumbs = new List<int>();
            listNumbs.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            List<int> evennumbers = listNumbs.FindAll(e => e % 2 == 0);

            var nubs  = listNumbs.Select(e => e.ToString());
            

            

            // Use of Extention Methods.
            listNumbs.printEachNumber();

            evennumbers.printEachNumber();

        }

        // Can be accessed out side.
        public static void sayHello()
        {
            WriteLine("hi from LinqToObjects1  !!!");
        }

        /// <summary>
        /// Print all the numbers in the List
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        private static void printEachNumber(this List<int> numbers)
        {
            foreach (int num in numbers)
            {
                WriteLine(num);
            }
        }

    }
}
