using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[10];
            //Console.WriteLine("Enter Elements");
            //for(int i=0;i<10;i++)
            //{
            //    num[i] = Byte.Parse(Console.ReadLine());
            //}
            // Declaratin and Initailzation
            int[] num = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Elements are ");
            for(int i = 0;i<num.Length;i++)
                Console.WriteLine(num[i]);
        }
    }
}
