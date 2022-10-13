using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class OptionalParameteres
    {
        //static float SI(int principal, int rate , int time)
        //{
        //    return (principal * rate * time) / 100;
        //}

        static float SI(int principal, int time,  int rate = 5)
        {
            return (principal * rate * time) / 100;
        }
        static void Main()
        {
            float si = SI(12000,8);
            Console.WriteLine(si);
            si = SI(20000, 2);
            Console.WriteLine(si);
        }
    }
}
