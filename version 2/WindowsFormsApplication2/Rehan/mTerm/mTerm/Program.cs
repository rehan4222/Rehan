using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mTerm
{
    class Program
    {
         

        static void Main(string[] args)
        {
            string c;
             string name;
             string b;
              string d;
             string[] a;
            Console.WriteLine("enter the name you want to check");
            name = Console.ReadLine();
            for (int i = 0; i < a.Length; i++)
            {
                if (i == 0)
                {
                    b = a[0];

                }

            }
            for (int i = a.Length; i < 1; i--)
            {
                if (i == a.Length)
                {
                    d = a[a.Length];
                }
            }
            if (b == d)
            {
                Console.WriteLine("it is a palindrome");
            }
            else
            {
                Console.WriteLine("it is not a palindrome");
            }
        }
        
    }
}
