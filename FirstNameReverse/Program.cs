using System;

namespace FirstNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma eesnimi");
            string userfirstname = Console.ReadLine();

            Console.WriteLine("Sisesta oma perekonnanimi");
            string userlastname = Console.ReadLine();

            for (int i = userfirstname.Length - 1; i >= 0; i--)

                Console.WriteLine(userfirstname[i]);

            for (int i = userlastname.Length - 1; i >= 0; i--)

                Console.WriteLine(userlastname[i]);






        }
    }
}
