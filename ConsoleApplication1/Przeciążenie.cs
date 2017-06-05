using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   
    class Przeciążanie
    {
        public static void Przeciążanie_metod()
        {
            Przeciążona_metoda("Metoda przeciążona działa!");
        }

        public static void Przeciążona_metoda(bool Powrót)
            {
            Console.Clear();
            if(Powrót)
            {
                Program.Main_menu();
            }
                

        }
        //Poniżej przeciążona metoda
        public static void Przeciążona_metoda(string metoda)
        {
            Console.WriteLine(metoda);
            Console.ReadKey();
            Przeciążona_metoda(true);
        }
    }
}
