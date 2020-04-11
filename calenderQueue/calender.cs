


using System;
using System.Collections.Generic;
using System.Text;

namespace stackpro
{
    class Class1
    {
        public void aa()
        {
                Console.WriteLine("Enter a month:");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a year:");
                int year = Convert.ToInt32(Console.ReadLine());
                int lastDate = GetLast_Date(month, year);
                int firstday = GetFirst_Date(month, 1, year);
                Console.WriteLine(firstday + "     //     " + lastDate);
                string[,] calenderArray = new string[6, 7];
                calenderArray = GetCalenderArray((7 - firstday + 1), lastDate);
                string[] day = new string[] { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
                for (int j = 0; j < day.Length; j++)
                {
                    Console.Write(day[j] + " ");
                }
                Console.WriteLine();


                for (int i = 0; i < 6; i++)
                {
                    if (i == 0 || i == 1)
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write(calenderArray[i, j] + "   ");
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 7; j++)
                        {
                            Console.Write(calenderArray[i, j] + "  ");
                        }
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            
                 bool LeapYear(int year)
                {
                    if (year % 4 == 0)
                    {                                                           
                        if (year % 100 == 0)
                        {                                                  
                            if (year % 400 == 0)
                            {                                                
                                return true;                                  
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }

                 int GetLast_Date(int month, int year)
                {
                    int[] lastDates = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                    if (month == 2)
                    {
                        if (LeapYear(year))
                        {
                            return 29;
                        }
                        else
                        {
                            return lastDates[month - 1];
                        }
                    }
                    else
                    {
                        return lastDates[month - 1];
                    }
                }

                int GetFirst_Date(int m, int d, int y)
                {
                    int y1 = y - ((14 - m) / 12);
                    int x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);
                    int m1 = m + (12 * ((14 - m) / 12)) - 2;
                    int d1 = (d + x + ((31 * m1) / 12)) % 7;
                    return d1;
                }

                string[,] GetCalenderArray(int firstDay, int lastDay)
                {
                    string[,] calenderArray = new string[6, 7];
                    int date = 1;
                    for (int i = 0; i < 6; i++)
                    {
                        if (i == 0)
                        {
                            for (int j = 7 - firstDay; j < 7; j++)
                            {
                                calenderArray[i, j] += date;
                                date++;
                            }
                        }
                        else
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                if (date <= lastDay)
                                {
                                    calenderArray[i, j] += date;
                                    date++;
                                }
                            }

                        }
                    }
                    return calenderArray;
                }
            
      
    



        }
    }


