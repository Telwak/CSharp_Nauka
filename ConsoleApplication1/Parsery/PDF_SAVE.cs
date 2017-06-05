using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using System.IO;
using log4net;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ConsoleApplication1
{
    class PDF_SAVE
    {
        private static readonly ILog Logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void PDF()
        {
            string Nazwa_pliku = "PDF.pdf";
            string Nazwa_maszyny = Environment.MachineName;
            string OS_VERSION = Environment.OSVersion.ToString();
            string Użytkiwnik = Environment.UserName;
            string Procesy_ilosc = Environment.ProcessorCount.ToString();
            string Scieżka = Directory.GetCurrentDirectory();
            try
            {

            

                if (!Directory.Exists(Scieżka + @"\Parsery\PDF"))
                {
                    
                    Directory.CreateDirectory(Scieżka + @"\Parsery\PDF");
                    
                }

                if (File.Exists(Scieżka + "/Parsery/PDF/" + Nazwa_pliku))
                {                  
                    Logger.Warn("Plik istnieje!Zostanie zaktualizowany!");
                    Console.ReadKey();
                }
                string[] Do_zapisu = { Nazwa_maszyny, OS_VERSION, Użytkiwnik, Procesy_ilosc };


                Document pdfDoc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream((Scieżka + "/Parsery/PDF/" + Nazwa_pliku), FileMode.OpenOrCreate));

            pdfDoc.Open();

                foreach(string a in Do_zapisu)
                {
                    pdfDoc.Add(new Paragraph(a));
                }

            pdfDoc.Close();
                Logger.Info("Utworzono PDF!");
                Console.ReadKey();
                Console.Clear();
                Program.Main_menu();
               

            }catch(Exception a)
            {
                Logger.Error(a);
            }
        }

    }
}
