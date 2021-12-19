using System;

namespace L2_8_Zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 0;
            int endNumber = 1000;

            do
            {
                if (startNumber % 2 == 0)
                {
                    Console.WriteLine("Liczba parzysta: " + startNumber);
                }
                startNumber++;
            } while (startNumber < endNumber);
        }
    }
}
