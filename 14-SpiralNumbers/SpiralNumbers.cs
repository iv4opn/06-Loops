using System;

    class SpiralNumbers
    {
        static void Main()
        {
            int[] spiral = new int[20];
            for (int i = 1; i <= spiral.Length; i++)
			{
			 spiral[i]=i;
			}
            foreach (var item in spiral)
	        {
                Console.WriteLine(spiral[item]);
	        }
        }
    }

