using System;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Please enter a year ?");
            int year = int.Parse(Console.ReadLine());

            if (IsLeapYear(year))
            {
                Console.WriteLine("Is a leap year");
            }
            else
            {
                Console.WriteLine("Is not a leap year");
            }

            Console.WriteLine("1785 {0}", IsLeapYear(178));
            Console.WriteLine("1786 {0}", IsLeapYear(1786));
            Console.WriteLine("1800 {0}", IsLeapYear(1900));
            Console.WriteLine("1482 {0}", IsLeapYear(1482));
        }



        static bool IsLeapYear(int year)
        {
            bool answer;
            if (year < 1582)
            {
                if (year % 4 == 0)
                {
                    answer = false;
                }
                else
                {
                    answer = true;
                }
            }
            else
            {
                // here the year is >= 1582

                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        answer = true;
                    }
                    else
                    {
                        answer = false;
                    }
                }
                else
                {
                    // here the year is >= 1582 and is not a century

                    if (year % 4 == 0)
                    {
                        answer = true;
                    }
                    else
                    { 
                        answer = false; 
                    }
                }
            }



            return answer;


        }
    }
}
