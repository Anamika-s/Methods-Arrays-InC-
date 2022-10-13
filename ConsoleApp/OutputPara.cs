using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class OutputPara
    {
        static void Change() { }
        static string CombineNames(string firtName , string lastName)
        {
            return string.Concat(firtName, ' ', lastName);
        }
        // How many max values a function can return uisng return statement? ONE
        //if we want a function to return more than 1 value , we have to use output paramteres

        static int Add(int x, int y) { return x + y; }
        static int Subtraction(int x, int y) { return x - y; }
        static int Product(int x, int y) { return x * y; }
        static int Divide(int x, int y) { return x / y; }
        
        // Function using output para
        static void Operations(int x , int y, out int add , out int subt
            , out int product, out int div)
        {
            add = x + y;
            subt = x - y;
            product = x * y;
            div = x / y;
        }
        static void Main()
        {
            //    Console.WriteLine(Add(10,2));
            //Console.WriteLine(Subtraction(20,2));
            // Calling Part
            int add, subt, prod, div;
            Operations(100, 2, out add, out subt, out prod, out div);
            Console.WriteLine($"Add is {add} Subtarction is {subt} Product is {prod} Quotient is {div}");




        }
    }
}
