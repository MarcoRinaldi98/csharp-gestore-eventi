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
        private int numeroPostiMassimi;
        public int NumeroPostiMassimi 
        { 
            get
            {
                return numeroPostiMassimi;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(null, "Il numero di posti non può essere inferiore a zero!");
                }
                else
                {
                    numeroPostiMassimi = value;
                }
            }
        }
        public int NumeroPostiPrenotati { get; private set; }

        public Evento(string titolo, DateTime data, int numeroPostiMassimi)
        {
            this.Titolo = titolo;
            this.Data = data;
            this.NumeroPostiMassimi = numeroPostiMassimi;
            this.NumeroPostiPrenotati = 0;
        }
    }
}
