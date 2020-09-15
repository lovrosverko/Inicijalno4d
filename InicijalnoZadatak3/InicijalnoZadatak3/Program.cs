using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoZadatak3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj:");
            string s = Console.ReadLine();
            int x = Convert.ToInt32(s);
            if (x % 4 == 0 && x % 6 == 0)
                Console.WriteLine("Broj je djeljiv sa 4 i sa 6");
            else if (x % 4 == 0)
                Console.WriteLine("Broj je djeljiv sa 4");
            else if (x % 6 == 0)
                Console.WriteLine("Broj je djeljiv sa 6");
            else
                Console.WriteLine("Broj nije djeljiv sa 4 ni sa 6");
        }
    }
}
