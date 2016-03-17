using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vpassignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            char chr;
            do
            {
                int age, day, month, year;
                Console.WriteLine("Enter no of siblings");
                do
                {
                    age = Convert.ToInt32(Console.ReadLine());
                    if (age<=0)
                    {
                        Console.WriteLine("<=0 value are not allowed please enter +tive values ");
                    }
                } while (age <= 0);
                
                string[] PerSiblings = new string[age];
                int[] days = new int[age];
                int[] months = new int[age];
                int[] years = new int[age];

                for (int i = 0; i < PerSiblings.Length; i++)
                {
                    Console.WriteLine("enter the date of birth for sibling  " + (i + 1));
                    PerSiblings[i] = Console.ReadLine();

                }
                for (int j = 0; j < PerSiblings.Length; j++)
                {
                    char[] chararr = PerSiblings[j].ToCharArray();
                    for (int i = 0; i < chararr.Length; i++)
                    {
                        if (chararr.Length == 8)
                        {
                            if (i < 1 && chararr[i] != '-')
                            {
                                days[j] = int.Parse(days[j].ToString() + chararr[i].ToString());
                            }
                            if (i > 1 && i < 3 && chararr[i] != '-')
                            {

                                months[j] = int.Parse(months[j].ToString() + chararr[i].ToString());

                            }
                            if (i > 3)
                            {
                                years[j] = int.Parse(years[j].ToString() + chararr[i].ToString());
                            }
                        }
                        else if (chararr.Length == 9)
                        {
                            if (chararr[2] == '-' && chararr[4] == '-')
                            {
                                if (i < 2 && chararr[i] != '-')
                                {
                                    days[j] = int.Parse(days[j].ToString() + chararr[i].ToString());
                                }
                                if (i > 2 && i < 4 && chararr[i] != '-')
                                {

                                    months[j] = int.Parse(months[j].ToString() + chararr[i].ToString());

                                }
                                if (i > 4)
                                {
                                    years[j] = int.Parse(years[j].ToString() + chararr[i].ToString());
                                }
                            }
                            else if (chararr[1] == '-' && chararr[4] == '-')
                            {
                                if (i < 1 && chararr[i] != '-')
                                {
                                    days[j] = int.Parse(days[j].ToString() + chararr[i].ToString());
                                }
                                if (i > 1 && i < 4 && chararr[i] != '-')
                                {

                                    months[j] = int.Parse(months[j].ToString() + chararr[i].ToString());

                                }
                                if (i > 4)
                                {
                                    years[j] = int.Parse(years[j].ToString() + chararr[i].ToString());
                                }
                            }

                        }
                        else if (chararr.Length == 10)
                        {
                            if (i < 2 && chararr[i] != '-')
                            {
                                days[j] = int.Parse(days[j].ToString() + chararr[i].ToString());
                            }
                            if (i > 2 && i < 5 && chararr[i] != '-')
                            {

                                months[j] = int.Parse(months[j].ToString() + chararr[i].ToString());

                            }
                            if (i > 5)
                            {
                                years[j] = int.Parse(years[j].ToString() + chararr[i].ToString());
                            }
                        }



                    }
                }

                for (int i = 0; i < PerSiblings.Length; i++)
                {
                    if (days[i] < 32 && months[i] < 13 && years[i] > 1900 && years[i] < 2017)
                    {
                        days[i] = DateTime.Now.Day - days[i];
                        months[i] = DateTime.Now.Month - months[i];
                        years[i] = DateTime.Now.Year - years[i];
                        if (days[i] < 0)
                        {
                            days[i] = days[i] - (days[i] * 2);
                            months[i]--;
                            days[i] = 30 - days[i];
                        }
                        if (months[i] < 0)
                        {
                            months[i] = months[i] - (months[i] * 2);
                            months[i] = 12 - months[i];
                            years[i]--;

                        }
                        Console.WriteLine("your age is " + days[i] + " days " + months[i] + " months " + years[i] + " years ");
                    }
                    else
                    {
                        Console.WriteLine("this is not a valid date kindly enter the valid date");
                    }



                }
                for (int i = 0; i < years.Length - 1; i++)
                {
                    year = years[i] - years[i + 1];
                    day = days[i] - days[i + 1];
                    month = months[i] - months[i + 1];
                    if (year < 0)
                    {
                        year = (year) - (year * 2);
                    }
                    if (month < 0)
                    {
                        month = (month) - (month * 2);
                    }
                    if (day < 0)
                    {
                        day = (day) - (day * 2);
                    }
                    Console.WriteLine("your's sibling difference between {0} and {1} is {2} days {3} months {4} years", i + 1, i + 2, day, month, year);
                }
                Console.WriteLine("do you want to continue ? (Y/N)");
                
                chr = Convert.ToChar(Console.ReadLine());
                if (chr=='y' || chr=='y')
                {
                    Console.Clear(); 
                }
                
            } 
            
            while (chr=='Y' || chr=='y');
            




        }
    }
}
