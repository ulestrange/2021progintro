using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(Add(5, 6));

            Console.WriteLine(Add(2, 3));

            int[] num = { 1, 2, 3 };

            int[] reversed = Reverse(num);

            Console.WriteLine(reversed);




        }

        static int sample()
        {
            return 3;
        }

        static string Echo(string testInput)
        {
            return testInput ;
        }

        static double Add (double num1, double num2)
        {
            return num1 + num2;
        }


        static int GetSum(int[] numbers)
        {

            int sum = 0;
            for (int i = 0; i < numbers.Length ; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        static int Min(int[] numbers)
        {

            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                    min = numbers[i];
            }

            return min;
        }


        static double GetAverageGrade(int[] grades)
        {
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }

            return sum/grades.Length;

        }

        static int[] Reverse(int[] numbers)
        {
            int[] reverseArray = new int[numbers.Length];

            for (int i =0; i< numbers.Length; i++)
            {
                reverseArray[numbers.Length- 1 - i] = numbers[i];
            }

            return reverseArray;
        }
    }
}
