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
        static int countMedian(List<int> input)
        {
            int countTemp = 0, medianTemp;

            System.Console.WriteLine("De lagrade tempraturerna är:");
            for (int i = 0; i < input.Count; i++){
                System.Console.WriteLine("Temp " + (i+1) + "|" + input[i]);
                countTemp = countTemp + input[i];
            }

            medianTemp = countTemp / input.Count;
            return medianTemp;
            // foreach (int temp in input)
            // {
            //     Console.WriteLine("Tempratur " + temp);
            //     countTemp = countTemp + temp;
            // }

        }
        static void Main(string[] args)
        {
            List<int> weatherData = new List<int>();
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
                    case 'S'://skriv ut data och medel

                        int medelvärde = countMedian(weatherData);
                        System.Console.WriteLine("Medelvärdet är: "+medelvärde);
                        break;
                    case 'T'://ta bort
                        countMedian(weatherData);
                        Console.WriteLine("Ange vilken mätning du vill ta bort.");
                        int toRemove = Convert.ToInt32(Console.ReadLine());
                        weatherData.RemoveAt(toRemove);
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
