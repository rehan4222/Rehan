using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repeated_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string a,b=null;

           
            int count;
           
            Console.WriteLine("write the string you want to check");
            a = Console.ReadLine();
            char[] chr = a.ToCharArray();
            count = chr.Length - 1;
            for (int i = count; i >0; i--)
            {
                b += chr[i].ToString();
            }
            if (a==b)
            {
                Console.WriteLine("tyhe given string is palindrome {0}:{1}",a,b);
            }
            else
            {
                Console.WriteLine("not a palindrome");
            }
            
        }
    }
}
