using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
namespace ConsoleApplication1
{
    class Dziedziczenie
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        class Koszty
        {
            public Koszty(int Dochód, int Wydatki)
            {
                Wydatki1 = Wydatki;
                Dochody = Dochód;
                
            }

            
            public int Dochody;
            public int Wydatki1;
        }

        class Zakupy : Koszty
        {
            public Zakupy(int Dochód, int Wydatki)
                : base(Dochód, Wydatki)
            {
           
            }
        }
        public static void Dziedziczenie_Test(int Dochody,int Wydatki)
            {
try { 
            Zakupy pros = new Zakupy(Dochody,Wydatki);
            Koszty fi = pros;
            int Reszta = fi.Dochody - fi.Wydatki1;


            Console.WriteLine("{1}Zarabiasz: {0}{1} Wydałeś: {2}{1} Pozostało: {3}",fi.Dochody, Environment.NewLine,fi.Wydatki1,Reszta);
            Console.ReadLine();
            }catch(Exception a)
            {
                Logger.Error(a);
            }
        }
    }
}
