using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Windows.Forms;


namespace ConsoleApplication1
{
    class Program
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {



            Data.Konwertowanie_Daty(DateTime.Now);
            Main_menu();
        }
        public static void Main_menu()
        {

            
            try
            {
                Console.WriteLine("0. Wyjście");
                Console.WriteLine("1. Pętle oraz wyjątki");
                Console.WriteLine("2. Enumy");
                Console.WriteLine("3. Konstruktory");
                Console.WriteLine("4. Pliki tekstowe (ZAPIS)");
                Console.WriteLine("5. Pliki tekstowe (ODCZYT)");
                Console.WriteLine("6. MD5");
                Console.WriteLine("7. Właściwości");
                Console.WriteLine("8. PDF (ZAPIS)");
                Console.WriteLine("9. Przeciążenie metody");
                Console.WriteLine("10. Kalkulator (Windows forms)");
                Console.WriteLine("11. Dziedziczenie");

                int Wybór = Int32.Parse(Console.ReadLine());

                switch (Wybór) // Definniujemy Nowego SWITCHA.
                {
                    case 0:
                        Environment.Exit(0);

                        break;
                    case 1: // Identycznie jak w IF/ELSE
                        Console.Clear(); //Czyścimy konsolę
                        Petle(); //Instrukcja do wykonania
                        break;

                    case 2:
                        Console.Clear();
                        ENUMY();
                        break;

                    case 3:
                        Console.Clear();
                        KONSTRUKTORY();
                        break;
                    case 4:
                        Console.Clear();
                        Tworzenie_pliku.Pobieranie_danych("Plik_Tekstowy.txt");
                        break;
                    case 5:
                        Console.Clear();
                        TXT_READER.Odczyt_z_pliku();
                        break;
                    case 6:
                        Console.Clear();
                      
                        MD5Hash("Telwak!");
                        break;
                    case 7:
                        Console.Clear();

                        WLASCIWOSCI.OSOBA();
                        break;
                    case 8:
                        Console.Clear();

                        PDF_SAVE.PDF();
                        break;
                    case 9:
                        Console.Clear();
                        Przeciążanie.Przeciążanie_metod();
                        break;
                    case 10:
                        Console.Clear();
                        Application.EnableVisualStyles();
                        Application.Run(new Kalkulator.Kalkulator());
                        break;
                    case 11:
                        Console.Clear();
                        Console.WriteLine("Podaj ile zarabiasz:");
                        int Zarobki = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Ile wydałeś:");
                        int Wydatki = Int32.Parse(Console.ReadLine());
                        Dziedziczenie.Dziedziczenie_Test(Zarobki,Wydatki);

                        break;
                    default:
                        Logger.Warn("Brak numeru");
                        //  Console.WriteLine("BRAK NUMERU");
                        Console.ReadKey();
                        Main_menu();
                        break;
                }

            }
            catch (Exception e)
            {
                Logger.Error(e);
                // Console.WriteLine("Wyjątek: {0}",e);
                Console.ReadKey();
            }
        }

        public static void Petle()
        {
            
            try
            {
                bool Własny_wyjątek ;
                Console.WriteLine("Wprowadz wartość: ");
                int i = Int32.Parse(Console.ReadLine()); // Parsowanie z Stringa to Int
                Console.WriteLine("Czy wprowadzić celowy wyjątek: 1-TAK, 2-NIE");
                int Wyjątek = Int32.Parse(Console.ReadLine());

                if (Wyjątek == 1)
                {
                    Własny_wyjątek = true;
                }
                else
                {

                    Własny_wyjątek = false;
                }

                for (int y = 0; y <= i; y++) //Pętla dodająca do y jeden
                {
                    Console.WriteLine("Literacja pętli: {0}", y); // Wyświetlanie w pętli I

                    if (y >= i) //Instrukcja warunkowa (IF)
                    {

                        Console.ReadKey(); // Oczekiwanie na naciśnięcie klawisza

                        if (Własny_wyjątek)
                        {

                            throw new Exception("Włączyłeś własny wyjątek!"); //Własny wyjątek

                        }
                        else
                        {
                            Console.WriteLine("BRAK WYJĄTKU");

                        }

                        Main_menu();
                    }
                }
            }
            catch (Exception e) // Wyjątek Powiązany z formatem. Można zastosować Ogólny (exception)
            {
                Logger.Error(e);
                //Console.WriteLine(e); // Wyświetlenie komunikatu wyjątku
                //throw; //Nie puszczamy programu dalej.
                Console.ReadKey();
            }

            Console.WriteLine("KONIEC");
            Console.ReadKey();
            Main_menu();


        }
    
    enum Narzeczona : int //DEFINIOWANIE ENUMA
        {
            // WARTOŚCI ENUMA
            Wiek = 23,
            Data_urodzenie = 1994,
        }

       public static void ENUMY()
        {
            Console.WriteLine("LISTA ENUMÓW: {0} , {1}", Narzeczona.Data_urodzenie, Narzeczona.Wiek); // Wyświetlenie listy enumów.

            Console.ReadKey();

            Main_menu();
        }

        
        class Samochód  
        {

            public string nazwa;
            public string marka; 
            public string paliwo;
            public Samochód(string nazwa, string marka, string paliwo) 
            { 
            this.nazwa = nazwa;
            this.marka = marka; 
            this.paliwo = paliwo;

        }

           
        }
      public static void KONSTRUKTORY ()
        {
            Samochód Wymarzony = new Samochód("PORSCHE", "911","BENZYNA");   // zostanie wywołany konstruktor domyślny
            Console.WriteLine("MARKA: {0} , NAZWA: {1} , PALIWO: {2}",Wymarzony.marka, Wymarzony.nazwa,Wymarzony.paliwo); 

            Console.ReadKey();
            Main_menu();
        }
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            Console.WriteLine(hash);
            Console.ReadKey();
            Console.Clear();
            Main_menu();
            return hash.ToString();
            
        }
    }

}




