using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV
{
    public class CV
    {
        public InformazioniPersonali InfoPersonali { get; set; }
        public List<Studi> studi = new List<Studi>();
        public Impiego impiego { get; set; }
        
        public string StampaDettagli()
        {

            return "Nome "+ InfoPersonali.Nome + " Cognome "+ InfoPersonali.Cognome +
                " Telefono " + InfoPersonali.Telefono + " Email "
               + InfoPersonali.Email;
        }
    } 
    public class InformazioniPersonali
        {
            public string Nome { get; set; }
            public string Cognome { get; set; }
            public string Telefono { get; set; }
            public string Email { get; set; }
        }

        public class Studi
        {
            public string Qualifica { get; set; }
            public string Istituto { get; set; }
            public string Tipo { get; set; }
            public string DataInizio { get; set; }
            public string DataFine { get; set; }
        }

        public class Impiego
        {
            public List<Esperienza> esperienza = new List<Esperienza>();
        } 
    public class Esperienza
            {
                public string Azienda { get; set; }
                public string JobTitle { get; set; }
                public string DataInizio { get; set; }
                public string DataFine { get; set; }
                public string Descrizione { get; set; }
                public string Compiti { get; set; }

            }
}
