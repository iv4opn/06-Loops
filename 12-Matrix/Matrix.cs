using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Matrix
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    Console.Write((i + j).ToString().PadLeft(3));
                }
                Console.WriteLine();
            }

        }
    }
