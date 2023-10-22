using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ponavljanje_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("Upisite n clan");
            n = Convert.ToInt32(Console.ReadLine());

            int[] niz = new int[n];
            niz[0] = 0;
            niz[1] = 1;

            for (int i = 2; i < n; i++)
            {
                niz[i] = niz[i - 1] + niz[i - 2];

            }
            Console.WriteLine("\n");

            for (int i = 0; i < niz.Length; i++) Console.WriteLine(niz[i]);

            Console.ReadKey();
        }
    }
}
