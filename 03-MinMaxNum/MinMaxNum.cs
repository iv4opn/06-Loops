using System;

    class MinMaxNum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                if (min > num)
                {
                    min = num;
                }
            }
            Console.WriteLine("The smallest number in sequence is: " + min);
            Console.WriteLine("The biggest number in sequence is: " + max);

        }
    }

