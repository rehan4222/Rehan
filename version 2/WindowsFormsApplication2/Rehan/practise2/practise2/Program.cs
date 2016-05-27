using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int [] sample=new int[10];
            
            for (int i = 0; i < 10; i++)
			{
			 sample[i]=i;

			}
            for (int i = 0; i < 10; i++)

			{
			 Console.WriteLine("sample[" + i + "] : " + sample[i]);
			}
        }
    }

}

