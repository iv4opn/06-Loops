using System;

    class ElucideanAlg
    {
        static void Main()
        {
            int Var1 = int.Parse(Console.ReadLine());
            int Var2 = int.Parse(Console.ReadLine());
            while (Var1 != 0 && Var2 != 0)
            {
                if (Var1 > Var2)
                {
                    Var1 -= Var2;
                }
                else
                {
                    Var2 -= Var1;
                }
            }
            Console.WriteLine(Math.Max(Var1, Var2));
        }
    }

