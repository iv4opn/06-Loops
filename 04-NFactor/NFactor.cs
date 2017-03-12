using System;
using System.Numerics;


class NFactor
{
    static void Main()
    {

        
            string nStr = Console.ReadLine();
            string kStr = Console.ReadLine();
            BigInteger n = BigInteger.Parse(nStr);
            BigInteger k = BigInteger.Parse(kStr);
            BigInteger fact = 1;
            if (n >= k)
            {
                for (BigInteger j = k + 1; j <= n; j++)
                {
                    fact *= j;
                }
                Console.WriteLine(fact);
            }
            else
            {
                for (BigInteger j = n + 1; j <= k; j++)
                {
                    fact *= j;
                }
                Console.WriteLine(1 / fact);
            }

    }
}
  
 
