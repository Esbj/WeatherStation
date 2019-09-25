using System;
using System.Collections.Generic;
namespace Väderstationen
{
    class Program
    {
        static void menu()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("                Vad vill du göra?");
            Console.WriteLine("");
            Console.WriteLine("[L]ägg till tempratur");
            Console.WriteLine("[S]kriv ut alla tempraturer & medeltemraturen");
            Console.WriteLine("[T]a bort ett värde");
            Console.WriteLine("[A]vsluta");
            Console.WriteLine("--------------------------------------------------");
        }
        List<int> Väderdata = new List<int>();
        static void add()
        {
            Console.WriteLine("Skriv in tempraturen");
            string sTemp = Console.ReadLine();
            try
            {
                int temp = Convert.ToInt32(sTemp);
            }
            catch
            {
                Console.WriteLine("Du matade inte in en tempratur i siffervärde.");
            }
        }
        static void writeMedian()
        {

        }
        static void taBort()
        {

        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Hej och välkommen till Väderstationen!");
            Console.WriteLine("");
            while (true)
            {
                menu();
                string input = Console.ReadLine().ToUpper();
                char choise = input[0];
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
                    default:
                        Console.WriteLine("Jag förstod inte vad du skrev.");
                        break;
                }
            }
        }
    }
}
