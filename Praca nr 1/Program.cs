using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Praca_nr_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Wprowadz swoje imie");
                var Imie = Console.ReadLine();

                Console.WriteLine("Wprowadz swoj miejsce urodzenia");
                var City = Console.ReadLine();

                Console.WriteLine("Wprowadz swoj rok urodzenia");
                var Year = int.Parse(Console.ReadLine());

                Console.WriteLine("Wprowadz swoj miesiac urodzenia");
                var Month = int.Parse(Console.ReadLine());

                Console.WriteLine("Wprowadz swoj dzien urodzenia");
                var Day = int.Parse(Console.ReadLine());

                var thisDay = DateTime.Now;

                var Birthday = new DateTime(Year, Month, Day);
                
                //Będe probowal rozwinac wiek o wykrywanie podania zawyzonej daty urodzenia.

                var wiek = thisDay.Year - Birthday.Year;
                if (thisDay.DayOfYear < Birthday.DayOfYear)
                {
                    wiek = wiek - 1;
                }
                Console.WriteLine($"Cześć {Imie} urodziłeś się w {City} masz {wiek} lat.");
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                Console.ReadLine();
            }

        }
    }
}
