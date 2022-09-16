using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadatakbr9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] niz = new int[n];
            int temp = 0;

            for(int i = 0; i < n; i++)
            {
                niz[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i<(n-1); i++)
            {
                for(int j = 0; j<n-i-1; j++)
                {
                    if(niz[j] > niz[j + 1])
                    {
                        temp = niz[j];
                        niz[j] = niz[j + 1];
                        niz[j+1] = temp;
                    }
                }
            }

            Console.WriteLine("Ispis:");
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine(niz[i]);
            }
            Console.ReadKey();
        }
    }
}
