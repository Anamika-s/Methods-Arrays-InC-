using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayDemo
{
    class JaggedArray
    {
        static void Main()
        {
            int[][] scores = new int[10][];

            Console.WriteLine("Enter Scores for first student");
            scores[0] = new int[2];
            for(int i=0;i<2;i++)
            {
                scores[0][i] = Byte.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter Scores for second student");

            scores[1] = new int[5];
            for (int i = 0; i < 5; i++)
            {
                scores[0][i] = Byte.Parse(Console.ReadLine());
            }


        }
    }
}
