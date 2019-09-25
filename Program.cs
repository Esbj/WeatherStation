using System;
using System.Collections.Generic;
namespace Väderstationen
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine("[L]ägg till tempratur");
            Console.WriteLine("[S]kriv ut alla tempraturer & medeltemraturen");
            Console.WriteLine("[T]a bort ett värde");
            Console.WriteLine("[A]vsluta");
        }
        static void add()
        {

        }
        static void writeMedian()
        {

        }
        static void taBort()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hej och välkommen till Väderstationen!");
            Console.WriteLine("Vad vill du göra idag?");
            menu();
            string input = Console.ReadLine().ToUpper();
            char choise = input[0];
            Console.WriteLine(choise);
            switch (choise)
            {
                case 'L':
                    add();
                    break;
                case 'S':
                    writeMedian();
                    break;
                case 'T':
                    taBort();
                    break;
                case 'A':
                    return;
            }
        }
    }
}
