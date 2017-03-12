using System;
using System.Numerics;

    class NKFactorial
    {
        static void Main()
        {
            BigInteger nF = 1;
            BigInteger kF = 1;

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            BigInteger differenceFact = 1;
            int difference = k - n;

            for (int i = 1; i <= n; i++)
            {
                nF *= i;
            }
            for (int i = 1; i <= k; i++)
            {
                kF *= i;
            }
            for (int i = 1; i <= difference; i++)
            {
                differenceFact *= i;
            }
            Console.WriteLine(nF * kF / differenceFact);

        }
    }

