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
            if (input.Count > 0)
            {
                int countTemp = 0, medianTemp;
                System.Console.WriteLine("De lagrade tempraturerna är:");
                for (int i = 0; i < input.Count; i++)
                {
                    countTemp = countTemp + input[i];
                    System.Console.WriteLine("Tempratur "+(i+1) + ": " + input[i]);
                }
                medianTemp = countTemp / input.Count;
                return medianTemp;
            }
            else
            {
                System.Console.WriteLine("Det finns inga lagrade mätningar.");
                return 0;
                
            }
        }
        static void Main(string[] args)
        {
            List<int> weatherData = new List<int>();

            weatherData.Add(1);
            weatherData.Add(2);
            weatherData.Add(3);
            
            

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
                        System.Console.WriteLine("Medelvärdet är: " + medelvärde);
                        break;
                    case 'T'://ta bort
                        if (weatherData.Count > 0){
                            countMedian(weatherData);
                            Console.WriteLine("Ange vilken mätning du vill ta bort.");
                            try{

                            int toRemove = Convert.ToInt32(Console.ReadLine());
                            weatherData.RemoveAt(toRemove-1);
                            break;
                            }catch{
                                Console.WriteLine("Ange indexplatsen på tepmraturen i siffervärde.");
                                break;
                            }
                        }else{
                            Console.WriteLine("Det finns ingen väderdata lagrad.");
                            break;
                        }
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