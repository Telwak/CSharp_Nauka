using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class OSOBA
    {
        public int Wiek { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        
    }

    class WLASCIWOSCI
    {
        public static void OSOBA()
        {
            // Definiowanie nowej klasy
            OSOBA DANUSIA = new OSOBA();
            DANUSIA.Imie = "Danusia";
            DANUSIA.Nazwisko = "Telwak";
            DANUSIA.Wiek = 23;

            Console.WriteLine("Imie: {0} {3} Nazwisko: {1} {3} wiek: {2}",DANUSIA.Imie,DANUSIA.Nazwisko,DANUSIA.Wiek, Environment.NewLine);
            Console.ReadKey();
            Program.Main_menu();
        }
        
    }
}
