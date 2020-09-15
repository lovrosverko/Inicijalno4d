using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoZadatak2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj sekundi:");
            string s1 = Console.ReadLine();
            int i = Convert.ToInt32(s1);
            int m = i / 60;
            int s = i - m * 60;
            Console.WriteLine("{0} minuta, {1} sekundi", m, s);
        }
    }
}
    }
}
