using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace ConsoleApplication1
{
    enum Colorcoding
    {
        pink = 20,
        red= 30, 
        blue = 40
    }

    public class Program 
    {

        static void Main(string[] args)
        {
            ForegroundColor = ConsoleColor.Yellow;
            BackgroundColor = ConsoleColor.Black;
            WriteLine("Lets do it, this time serious");
            WriteLine("");
            WriteLine("######       # ");
            WriteLine("#           # #" );
            WriteLine("####       #####");
            WriteLine("#         #     #");
            WriteLine("#        #       #");

            WriteLine("--------------------------------------");
            WriteLine();

            LinqToObjects.sayHello();
            //ActionAndFuncDelegates class1 = new ActionAndFuncDelegates(displayMessage, Convert.ToInt32(ReadLine())); 
            ReadLine();


        }

        // Call back function or notification message
        private static void displayMessage(string message, ConsoleColor txtColor, int prntCount)
        {
            ConsoleColor prev = Console.ForegroundColor;
            Console.ForegroundColor = txtColor;
            for (int i = 0; i < prntCount; i++)
            {
                Console.WriteLine(message);
            }

            Console.ForegroundColor = prev;
        }
    }
}
