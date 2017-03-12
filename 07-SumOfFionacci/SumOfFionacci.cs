using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class Program
    {
      
        private static BigInteger currentNumber;
        private static BigInteger firstNumber = 0;
        private static BigInteger secondNumber = 1;
        private static BigInteger sum = 1;

        static void Main(string[] args)
        {
            string inputNumberStr = Console.ReadLine();
            int n = int.Parse(inputNumberStr);
            switch (n)
            { 
                case 1:
                    Console.WriteLine(firstNumber);
                    break;
                case 2:
                    Console.WriteLine(secondNumber+ firstNumber);
                    break;
                case 3:
                    Console.WriteLine(sum + firstNumber + secondNumber);
                    break;
                default:
                    PrintTheSumOfFirstNFibonacciElemnts(n);
                    break;
            }
            
        }

        private static void PrintTheSumOfFirstNFibonacciElemnts(int n)
        {
            for (int i = 0; i < n - 2; i++)
            {
                currentNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = currentNumber;
                sum += currentNumber;
            }
            Console.WriteLine(sum);
        }
    }

    

