using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;


namespace ConsoleApplication1
{
    class Tworzenie_pliku
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void Pobieranie_danych(string Nazwa_pliku)
        {
            
        string Nazwa_maszyny = Environment.MachineName;
            string OS_VERSION = Environment.OSVersion.ToString();
            string Użytkiwnik = Environment.UserName;
            string Procesy_ilosc = Environment.ProcessorCount.ToString();
            string Scieżka = Directory.GetCurrentDirectory();
            try
            {

                if (!Directory.Exists(Scieżka + @"\Parsery\TXT"))
                {
                   // while (Directory.Exists(Scieżka + @"\Parsery\TXT"))
                   // {
                        Directory.CreateDirectory(Scieżka + @"\Parsery\TXT");
                   // }
                }

                if (File.Exists(Scieżka + "/Parsery/TXT/" + Nazwa_pliku))
                {
                    File.Delete(Scieżka + "/Parsery/TXT/" + Nazwa_pliku);
                    // Console.WriteLine("Plik istnieje! Zaktualizowano plik!");
                    Logger.Warn("Plik istnieje! Zaktualizowano plik!");
                }

                string[] Do_zapisu = { Nazwa_maszyny, OS_VERSION, Użytkiwnik, Procesy_ilosc };


                File.WriteAllLines(Scieżka + "/Parsery/TXT/" + Nazwa_pliku, Do_zapisu);
                //Console.Write("Utworzono plik tekstowy!");
                Logger.Info("Utworzono plik tekstowy!");
                Console.ReadKey();
                Program.Main_menu();
            }
            catch (Exception e)
            {
                //Console.Write("Wyjątek: {0}", e);
                Logger.Error(e);
                Console.ReadKey();     
            }
        }
    }
}