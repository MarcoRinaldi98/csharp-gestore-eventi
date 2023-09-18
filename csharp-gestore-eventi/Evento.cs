using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        // ATTRIBUTI
        private string titolo;
        public string Titolo 
        {
            get
            {
                return titolo;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(null, "Il campo \"Titolo\" non può essere vuoto!");
                }
                else
                {
                    titolo = value;
                }
            } 
        }
        private DateTime data;
        public DateTime Data
        {
            get
            {
                return data;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(null, "La data di un evento non può essere inferiore alla data di oggi!");
                }
                else
                {
                    data = value;
                }
            }
        }
        public int NumeroPostiMassimi { get; private set; }
        public int NumeroPostiPrenotati { get; private set; }

        // COSTRUTTORE
        public Evento(string titolo, DateTime data, int numeroPostiMassimi)
        {
            this.Titolo = titolo;
            this.Data = data;
            if(numeroPostiMassimi < 0)
            {
                throw new ArgumentException("La capienza massima deve essere un numero positivo.");
            } else
            {
                this.NumeroPostiMassimi = numeroPostiMassimi;
            }
            this.NumeroPostiPrenotati = 0;
        }

        // METODI
        // metodo che aggiunge i posti passati come parametro ai posti prenotati
        public void PrenotaPosti(int numeroPosti)
        {
            if (Data <= DateTime.Now )
            {
                throw new InvalidOperationException("Impossibile prenotare posti per un evento passato.");
            }
            if (numeroPosti <= 0)
            {
                throw new ArgumentException("Il numero di posti da prenotare deve essere maggiore di zero.");
            }
            if (NumeroPostiPrenotati + numeroPosti > NumeroPostiMassimi)
            {
                throw new InvalidOperationException($"Non ci sono abbastanza posti disponibili per questo evento, sono ancora disponibili {NumeroPostiMassimi - NumeroPostiPrenotati} posti.");
            }
            NumeroPostiPrenotati += numeroPosti;
        }
        // metodo che riduce i posti passati come parametro ai posti prenotati
        public void DisdiciPosti(int numeroPosti)
        {
            if (Data <= DateTime.Now)
            {
                throw new InvalidOperationException("Impossibile disdire posti per un evento passato.");
            }
            if (numeroPosti <= 0)
            {
                throw new ArgumentException("Il numero di posti da disdire deve essere maggiore di zero.");
            }
            if (NumeroPostiPrenotati < numeroPosti)
            {
                throw new InvalidOperationException($"Non ci sono abbastanza posti prenotati da disdire, sono stati prenotati {NumeroPostiPrenotati} posti");
            }
            NumeroPostiPrenotati -= numeroPosti;
        }
        // metodo che sovrascrive la rappresentazione default del metodo ToString()
        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy") + " - " + Titolo;
        }
    }
}
