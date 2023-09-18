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
        public string Relatore {  get; set; }
        public double Prezzo { get; set; }

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
