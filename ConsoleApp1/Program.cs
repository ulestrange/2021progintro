using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSymbol(15, '?');
        }


        static void WriteSymbol(int number, char symbol)
        {
            for (int i = 0; i < number; i++)
            {
                WriteInnerLoop(i, symbol);
                Console.WriteLine();
            }

        }

        static void WriteInnerLoop(int number, char symbol)
        {
            for (int j = 0; j < number + 1; j++)
            {
                Console.Write(symbol);
            }
        }
    }
}
