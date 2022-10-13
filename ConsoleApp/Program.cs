using System;

namespace ConsoleApp
{
    class Program
    {
        static void Add1(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        static void Add2(int x, int y, int z)
        {
            Console.WriteLine(x + y +z);
        }
        static void Add3(string x, string y)
        {
            Console.WriteLine(string.Concat(x , ' ' , y));
        }
        static void Add4(int x, float y)
        {
            Console.WriteLine(x + y);
        }
        static void Main(string[] args)
        {
            Add1(1, 2);
            Add2(2, 3, 4);
            Add3("abc", "def");
            Console.WriteLine("Hello World!");
        }
    }
}
