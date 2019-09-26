using System;
using System.Collections.Generic;
namespace Väderstationen
{
    class Program
    {
        static List<int> weatherData = new List<int>();
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
                    case 'L'://lägg till
                        Console.WriteLine("Skriv in tempraturen");
                        string sTemp = Console.ReadLine();
                        try
                        {
                            int temp = Convert.ToInt32(sTemp);
                            weatherData.Add(temp);
                        }
                        catch
                        {
                            Console.WriteLine("Du matade inte in en tempratur i siffervärde.");
                        }
                        break;
                    case 'S'://skriv ut
                        int countTemp = 0, medianTemp;
                        foreach (int temp in weatherData)
                        {
                            Console.WriteLine("Tempratur " + temp);
                            countTemp = countTemp + temp;
                        }
                        medianTemp = countTemp / weatherData.Count;
                        Console.WriteLine("Medeltempraturen är:" + medianTemp);
                        break;
                    case 'T'://ta bort
                        break;
                    case 'A'://avsluta
                        return;
                    default:
                        Console.WriteLine("Jag förstod inte vad du skrev.");
                        break;
                }
            }
        }
    }
}
