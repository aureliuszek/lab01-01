using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //tu piszemy kod
            Console.WriteLine("Program na powitanie.");
            Console.Write("podaj imię: ");
            string imie;
            imie = Console.ReadLine();

            Console.Write("podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            Console.WriteLine("Witaj " + imie + " " + nazwisko);
            Console.WriteLine("Witaj {0} {1}. Czy Pan {0} rzeczywiście nazywa się {1}?", imie, nazwisko);

            Console.Write("podaj wiek: ");
            //int wiek = console.ReadLine(); //błąd - niezgodność typów
            int wiek = 0;
            while (wiek <= 0)
            {
                wiek = Convert.ToInt32(Console.ReadLine());
                if (wiek <= 0)
                {
                    Console.WriteLine("Błąd programu!");
                }
                else if (wiek >= 67)
                {
                    Console.WriteLine("Jesteś emerytem");
                }
                else
                    {
                    Console.WriteLine("Zostało ci {0} lat do emerytury.", 67 - wiek);
                }
            }
            Console.ReadKey();
            //...
        }
    }
}
