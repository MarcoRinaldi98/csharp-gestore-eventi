using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        public string Titolo { get; private set; }
        public DateTime Data { get; private set; }
        public int NumeroPostiMassimi { get; }
        public int NumeroPostiPrenotati { get; }

        public Evento(string titolo, DateTime data, int numeroPostiMassimi , int numeroPostiPrenotati)
        {
            this.Titolo = titolo;
            this.Data = data;
            this.NumeroPostiMassimi = numeroPostiMassimi;
            this.NumeroPostiPrenotati = numeroPostiPrenotati;
        }
    }
}
