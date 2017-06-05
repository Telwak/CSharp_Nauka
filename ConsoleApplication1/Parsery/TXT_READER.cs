using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using System.IO;


namespace ConsoleApplication1
{

    class TXT_READER
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Odczyt_z_pliku()
        {
            try
            {
                string Scieżka = Directory.GetCurrentDirectory();

                if (!File.Exists(Scieżka + @"\Parsery\TXT\Plik_Tekstowy.txt"))
                {
                    Logger.Warn("Plik nie istnieje! Zostanie Utworzony!");
                    Console.ReadKey();
                    Tworzenie_pliku.Pobieranie_danych("Plik_Tekstowy.txt");
                }

                string[] ODCZYTY = File.ReadAllLines(Scieżka + @"\Parsery\TXT\Plik_Tekstowy.txt");
               
                foreach (string s in ODCZYTY)
                {
                    Console.WriteLine(s);
                }
                Console.ReadKey();
                Console.Clear();
                Program.Main_menu();
            }
            catch (Exception a)
            {
                Logger.Error(a);
            }
        }

    }
}
