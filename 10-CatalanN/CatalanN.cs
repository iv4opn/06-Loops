using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class CatalanN
    {
        static void Main()
        {

            int N, secondN;
            BigInteger factorielN = 1, productN = 1, sum = 1;  
            Console.WriteLine("Enter first N Catalan Numbers. C(N)");
            do
            {
                Console.WriteLine("Number N: ");
            } while (!int.TryParse(Console.ReadLine(), out N));
            secondN = N;
            for (N = 0; N < secondN; N++)
            {
                productN = factorielN = 1;
                for (int i = 1; i < N; i++)           
                {
                    productN *= (i + 1 + N);
                    factorielN *= i + 1;
                }
                Console.WriteLine("Catalan({1}) = {0}", productN / factorielN, N); ;
                sum += (productN / factorielN);
            }
            Console.WriteLine( sum);
        }
    }

