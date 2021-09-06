using System;

namespace Kolman_TM5_TimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x >= 0 && x <= 100)
            {
                for (int i = 1; i <= x; i++)
                {
                    Console.WriteLine(i + " " + "Abracadabra");
                }

            }
            else
            {
                Console.WriteLine("Please Choose A Number between 1 and 100");
            }

            

            
         }
    }
}


