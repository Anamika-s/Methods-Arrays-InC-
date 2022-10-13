using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class CallByValue
    {
        static void Change1(int x)
        {
            x = 100;
            Console.WriteLine("Value of x in Change1 is " + x);

        }
        static void Main()
        {
            int x = 10;
            Console.WriteLine("Value of x in Main before Calling Change1 is " + x);
            Change1(x);
            Console.WriteLine("Value of x in Main after Calling Change1 is " + x);

        }
    }
}
