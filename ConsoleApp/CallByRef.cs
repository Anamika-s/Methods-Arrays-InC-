using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    public class CallByRef
    {
         //&x
        public static void Change1(ref int x)
        {
            x = 100;
            Console.WriteLine("Value of x in Change1 is " + x);

        }
        static void Main()
        {
            int x = 10;
            Console.WriteLine("Value of x in Main before Calling Change1 is " + x);
            Change1(ref x);
            Console.WriteLine("Value of x in Main after Calling Change1 is " + x);

        }
    }
}
