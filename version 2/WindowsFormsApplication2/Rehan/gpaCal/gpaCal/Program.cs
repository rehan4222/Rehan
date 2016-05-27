using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gpaCal
{
    class Program
    {
        static void Main(string[] args)
        {
            string name="0";
            int age=0;
            char sec='0';
            double salary=0;
            double cgpa=0;
            info(ref name, ref age, ref sec, ref salary, ref cgpa);
            Console.WriteLine("uper wali values {0},{1},{2}",name,age,sec);
                   
        }
        public static void info(ref string name,ref int age,ref char sec,ref double salary, ref double cgpa)
        {
             //String name;
            //int age;
            //char sec;
           // Double salary;
           // Double cgpa;
            Console.WriteLine("Enter your Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your section:");
            sec=Convert.ToChar(Console.ReadLine());
            Console.WriteLine("enter your salary serious wali");
            salary=Convert.ToDouble((Console.ReadLine()));
            Console.WriteLine("enter your cgpa");
            cgpa=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0},{1},{2}",name,age,sec);
        }
    }
}
