using System;

namespace Kolman_TM5_TimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            //Count Starting From 1
            int OrderCounter = 1;
            while (length >= OrderCounter)
            {
                Console.WriteLine(OrderCounter.ToString() + " " + "Abracadabra");
                OrderCounter++;
            }
        }
    }
}

