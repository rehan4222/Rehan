using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int number = 3;

            Console.WriteLine(sumValue(a, number));
            Console.WriteLine(Forward(a, number));
        }
        public static int sumValue(int[] arr, int value)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    for (int j = i; j >= 0; j--)
                    {
                        sum += arr[j];
                    }
                }
            }
            return sum;
        }
        public static int Forward(int[] arra,int values)
        {
            int sumF = 0;
            for (int i = 0; i < arra.Length; i++)
            {
                if (arra[i]==values)
                {
                    for (int j = i; j <arra.Length ; j++)
                    {
                        sumF += arra[j];
                    }
                }
            }
                return sumF;
        }
    }
}