using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        // ATTRIBUTI
        public string Titolo { get; set; }
        List<Evento> eventi;

        // COSTRUTTORE
        public ProgrammaEventi(string titolo) 
        {
            this.Titolo = titolo;
            eventi = new List<Evento>();
        }
    }
}
