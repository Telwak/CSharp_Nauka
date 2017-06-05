using System;
using log4net;
namespace ConsoleApplication1
{
    class Data
    {

        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        enum Miesiące
        {
            Styczeń = 1,
            Luty ,
            Marzec ,
            Kwiecień ,
            Maj ,
            Czerwiec ,
            Lipiec ,
            Sierpień ,
            Wrzesień ,
            Pazdziernik ,
            Listopad ,
            Grudzień 
        };

        public static void Konwertowanie_Daty(DateTime Data)
        {
       
            try
            {
                string  Gotowy_miesiąc;
                string Gotowy_dzień;

                string Rok = (Data.Year).ToString(); //Wyciągniecię roku
                int Miesiące = (Data.Month); //Wyciągniecię Miesiąca
                string Dzień = (Data.DayOfWeek).ToString(); //Wyciągniecię Dnia w tygodniu (Angielski)
                string Dzień_1 = (Data.Day).ToString(); //Wyciągniecię Dnia
                string Rok_enum = Rok.ToString();//Wyciągniecię Roku


                Gotowy_miesiąc = Enum.GetName(typeof(Miesiące), Miesiące); //Pobieranie danych Miesiąca z Enuma

                switch (Dzień)
                {
                    case "Monday":
                        Gotowy_dzień = "Poniedziałek";
                        Console.Write("Bierząca data: {0}-{3} {1}a-{2}", Gotowy_dzień, Gotowy_miesiąc,Rok, Dzień_1);
                        break;

                    case "Tuesday":
                        Gotowy_dzień = "Wtorek";
                        Console.Write("Bierząca data: {0} - {3} {1}a - {2}r", Gotowy_dzień, Gotowy_miesiąc, Rok, Dzień_1);
                        break;

                    case "Wednesday":
                        Gotowy_dzień = "Środa";
                        Console.Write("Bierząca data: {0} - {3} {1}a - {2}r", Gotowy_dzień, Gotowy_miesiąc, Rok, Dzień_1);
                        break;

                    case "Thursday":
                        Gotowy_dzień = "Czwartek";
                        Console.Write("Bierząca data: {0} - {3} {1}a - {2}r", Gotowy_dzień, Gotowy_miesiąc, Rok, Dzień_1);
                        break;

                    case "Friday":
                        Gotowy_dzień = "Piątek";
                        Console.Write("Bierząca data: {0} - {3} {1}a - {2}r", Gotowy_dzień, Gotowy_miesiąc, Rok, Dzień_1);
                        break;

                    case "Saturday":
                        Gotowy_dzień = "Sobota";
                        Console.Write("Bierząca data: {0} - {3} {1}a - {2}r", Gotowy_dzień, Gotowy_miesiąc, Rok, Dzień_1);
                        break;

                    case "Sunday":
                        Gotowy_dzień = "Niedziela";
                        Console.Write("Bierząca data: {0} - {3} {1}a - {2}r", Gotowy_dzień, Gotowy_miesiąc, Rok, Dzień_1);
                        break;


                    default:
                       
                        break;
                }

                Console.Write(Environment.NewLine);
                Console.Write(Environment.NewLine);//Przejście do nowej lini

            }
            catch (Exception a)
            {

                //  Console.WriteLine("Wyjątek: {0}",a);
                Logger.Error(a);
            }
        }


        }
    }

