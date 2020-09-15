using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InicijalnoZadatak4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, Broj = 32;
            int[] arr = new int[Broj];
            Random x = new Random();
            do
            {
                int y = x.Next(Broj) + 1;
                bool flag = false;
                for (int i = 0; i < n; i++)
                    if (arr[i] == y) // Ako je broj već dodijeljen,
                    { // ne dodijeljuj ga
                        flag = true;
                        break;
                    }
                if (flag == false) // Broj nije dodijeljen
                    arr[n++] = y;
            } while (n != Broj);
            for (int i = 0, j = 0; i < Broj / 2; i++, j += 2)
                Console.WriteLine("{0} vs. {1}", arr[j], arr[j + 1]);

            Console.ReadKey();
        }
    }
}
