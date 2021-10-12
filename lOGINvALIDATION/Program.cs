using System;

namespace lOGINvALIDATION
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("sisesta oma eesnimi");
                string userfirstname = Console.ReadLine();
                int i = 0;
                while (i < 3)
                {
                Console.WriteLine("Sisesta PIN:");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    i = 3;
                }
                else
                {
                i = i + 1;
                Console.WriteLine($"Vale PIN. {3 - i} Midagi läks valesti");
                }
                Console.WriteLine("Tere tulemast");





            }
        }
    }
} 
