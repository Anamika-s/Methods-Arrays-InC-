using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    class _2DArrayDemo
    {
        static void Main()
        {
            //int[,] a = new int[3, 3];
            //Console.WriteLine("Enter elements");
            //for (int i = 0; i < 3; i++)
            //{
            //    for (int y = 0; y < 3; y++)
            //    {
            //        a[i, y] = Byte.Parse(Console.ReadLine());
            //    }
            //}
            // Declaratin and Initailzation
            int[,] a = new int[,] {
                {1,2,3 },
                {3,4,5},
                {4,5,10 }
            };
            Console.WriteLine("Elements are ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(a[i, y] + "\t");
                }
            }
        }
    }
}