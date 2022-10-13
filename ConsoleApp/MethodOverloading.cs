using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class MethodOverloading
    {
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Add(int x, int y, int z)
        {
            Console.WriteLine(x + y + z);
        }
        static void Add(string x, string y)
        {
            Console.WriteLine(string.Concat(x, ' ', y));
        }
        static void Add(int x, float y)
        {
            Console.WriteLine(x + y);
        }
        static void Main(string[] args)
        {
            Add(2, 5f);
            Add("Abc", "def");

            Console.WriteLine("Hello World!");
        }
    }
}
