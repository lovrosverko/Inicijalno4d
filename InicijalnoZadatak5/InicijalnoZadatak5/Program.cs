using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoZadatak5
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX = 39;
            for (int a = 1; a <= MAX - 6; a++)
                for (int b = a + 1; b <= MAX - 5; b++)
                    for (int c = b + 1; c <= MAX - 4; c++)
                        for (int d = c + 1; d <= MAX - 3; d++)
                            for (int e = d + 1; e <= MAX - 2; e++)
                                for (int f = e + 1; f <= MAX - 1; f++)
                                    for (int g = f + 1; g <= MAX; g++)
                                        Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}",
                                        a, b, c, d, e, f, g);
        }
    }
}
