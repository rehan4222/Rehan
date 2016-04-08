using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoDarray
{
    class metrix
    {
       public int[,] m1 = new int[2,2];
       public void insert()
       {
           for (int i = 0; i < 2; i++)
           {
               for (int j = 0; j < 2; j++)
               {
                   m1[i, j] = Convert.ToInt32(Console.ReadLine());

               }
           }
       }
        public void display()
       {
           for (int i =  0; i < 2; i++)
           {
               
               
           for (int j = 0; j < 2; j++)
           {
               Console.Write(m1[i, j]+"\t");
           }
           Console.WriteLine();
           }
       }
        public void transpose()
        {
            for (int i = 0; i < 2; i++)
            {


                for (int j = 0; j < 2; j++)
                {
                    Console.Write(m1[j, i] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {;
            metrix m = new metrix();
            m.insert();
            m.display();
            m.transpose();
        }
    }
}
