using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Conferenza : Evento
    {
        // ATTRIBUTI
        private string relatore;
        public string Relatore { 
            get
            {
                return relatore;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(null, "Il campo \"Relatore\" non può essere vuoto!");
                }
                else
                {
                    relatore = value;
                }
            }
        }
        private double prezzo;
        public double Prezzo {
            get
            {
                return prezzo;
            }
            set
            {
                if (prezzo < 0)
                {
                    throw new ArgumentNullException(null, "Il Prezzo non puo essere inferiore a 0!");
                }
                else
                {
                    prezzo = value;
                }
            }
        }

        // COSTRUTTORE
        public Conferenza(string titolo, DateTime data, int numeroPostiMassimi, string relatore, double prezzo) : base(titolo, data, numeroPostiMassimi)
        {
            this.Relatore = relatore;
            this.Prezzo = prezzo;
        }

        // METODI
        public string DataOraFormattata()
        {
            return Data.ToString("dd/MM/yyyy HH:mm");
        }

        public string PrezzoFormattato()
        {
            return Prezzo.ToString("0.00") + " euro";
        }

        public override string ToString()
        {
            return $"{DataOraFormattata()} - {Titolo} - {Relatore} - {PrezzoFormattato()}";
        }
    }
}
