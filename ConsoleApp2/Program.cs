using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleApp.NamedParameter.DisplayDetails(1, "Ajay", address: "Delji", score: 90, managername: "Deepak");
            int x = 200;
            ConsoleApp.CallByRef.Change1(ref x);
        }
    }
}
