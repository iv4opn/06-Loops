using System;
using System.Numerics;


    class CatalaNnumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double CatlanN;

            BigInteger n2Factoriаl = 1;
            BigInteger nFactoriаl = 1;
            BigInteger n1Factoriаl = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                n2Factoriаl *= i;
            }
            for (int i = 1; i <= n; i++)
            {
                nFactoriаl *= i;
            }
            n1Factoriаl = nFactoriаl * (n + 1);

            CatlanN = (double)n2Factoriаl / ((double)n1Factoriаl * (double)nFactoriаl);
            Console.WriteLine("The number of Catlan is: " + CatlanN);

        }
    }

