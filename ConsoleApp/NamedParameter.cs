using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
   public class NamedParameter
    {
        public static void DisplayDetails(int rn, string name , string managername, string address, int score)
        {
            Console.WriteLine($"Rn is {rn} Name is {name} Address is {address} Scores are {score}");
        }
        static void Main()
        {
            DisplayDetails(1, "ajay", "mahesh" , "delhi", 90);
            // Named Parameter
            DisplayDetails(name: "Ajay", managername: "Mahesh", score: 90, address: "Delhi", rn: 2);

        }
    }
}
