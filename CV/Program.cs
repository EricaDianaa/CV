using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CV cv = new CV(); 
            //infopersonali
            InformazioniPersonali info =new InformazioniPersonali();
            info.Nome = "Erica";
            info.Cognome = "Diana";
            info.Telefono = "83923893803";
            info.Email="ericadiana@gmail.com";

            cv.InfoPersonali = info;

            //studi
            Studi  studi = new Studi();
            studi.Qualifica = "Front-end";
            studi.Istituto = "Epicode";
            studi.Tipo = "informatica";
            studi.DataInizio = "1/05/2023";
            studi.DataInizio = "28/08/2023";

            Studi studi1 = new Studi();
            studi1.Qualifica = "back-end";
            studi1.Istituto = "Epicode";
            studi1.Tipo = "informatica";
            studi1.DataInizio = "30/08/2023";
            studi1.DataInizio = "1/12/2023";

            cv.studi.Add(studi);
            cv.studi.Add(studi1);

            //impiego
            Impiego impiego = new Impiego();
            
            Esperienza esperienza = new Esperienza();
            esperienza.Azienda = "Bar Risporante";
            esperienza.JobTitle = "Barista";
            esperienza.DataInizio = "20/04/2020";
            esperienza.DataFine = "20/04/2021";
            esperienza.Descrizione = "descrizione";
            esperienza.Compiti = "Servizio Clienti,Accoglienza";

            Esperienza esperienza1 = new Esperienza();
            esperienza1.Azienda = "Azienda";
            esperienza1.JobTitle = "Full Stack";
            esperienza1.DataInizio = "1/04/2024";
            esperienza1.DataFine = "20/08/2024";
            esperienza1.Descrizione = "descrizione";
            esperienza1.Compiti = "Programmatore";

            impiego.esperienza.Add(esperienza);
            impiego.esperienza.Add(esperienza1 );
            cv.impiego = impiego;




            
            Console.WriteLine(cv.InfoPersonali.Nome);
            Console.WriteLine(cv.InfoPersonali.Cognome);
            Console.WriteLine(cv.InfoPersonali.Telefono);
            Console.WriteLine(cv.InfoPersonali.Email);

            Console.WriteLine(" ");

            for (int i = 0; i < cv.studi.Count; i++)
            {
                Console.WriteLine(cv.studi[i].Qualifica);
                Console.WriteLine(cv.studi[i].Istituto);
                Console.WriteLine(cv.studi[i].Tipo);
                Console.WriteLine(cv.studi[i].DataInizio);
                Console.WriteLine(cv.studi[i].DataFine);

            }


            for (int i = 0; i < cv.impiego.esperienza.Count; i++)
            {

                Console.WriteLine(" ");
                Console.WriteLine(cv.impiego.esperienza[i].Azienda);
                Console.WriteLine(cv.impiego.esperienza[i].JobTitle);
                Console.WriteLine(cv.impiego.esperienza[i].DataInizio);
                Console.WriteLine(cv.impiego.esperienza[i].DataFine);
                Console.WriteLine(cv.impiego.esperienza[i].Descrizione);
                Console.WriteLine(cv.impiego.esperienza[i].Compiti);
            }

            Console.ReadLine();
        }
    }
}
