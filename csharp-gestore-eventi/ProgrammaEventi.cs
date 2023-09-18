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
        private string titolo;
        public string Titolo {
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
        List<Evento> Eventi {  get; set; }

        // COSTRUTTORE
        public ProgrammaEventi(string titolo) 
        {
            this.Titolo = titolo;
            Eventi = new List<Evento>();
        }

        // METODI
        // metodo per aggiungere un evento alla lista del programma eventi
        public void AggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
        }
        // metodo che restituisce una lista di eventi che vengono svolti in una determinata data
        public List<Evento> TrovaEventiPerData(DateTime data)
        {
            return Eventi.FindAll(e => e.Data.Date == data.Date);
            /* OPPURE
             List<Evento> risultati = new List<Evento>();

            foreach (Evento evento in Eventi)
            {
                if (evento.Data == data)
                    risultati.Add(evento);
            }
            return risultati;
            */
        }
        // metodo che restituisce il numero di eventi presenti nel programma attualmente
        public int NumeroDiEventi()
        {
            return Eventi.Count;
        }
        // metodo che svuota la lista di eventi
        public void SvuotaEventi()
        {
            Eventi.Clear();
        }
        // metodo che restituisce una grafica con il nome del programma seguito dalla lista di tutti i suoi eventi
        public string ElencoEventiPerProgramma()
        {
            string risultato = $"{Titolo}\n";
            foreach (var evento in Eventi)
            {
                risultato += evento.ToString() + "\n";
            }
            return risultato;
        }

        // METODI STATICI
        // metodo statico che restituisce la rappresentazione in stringa della nostra lista di eventi
        public static string StampaEventi(List<Evento> eventi)
        {
            string risultato = "";
            foreach (var evento in eventi)
            {
                risultato += evento.ToString() + "\n";
            }
            return risultato;
        }
    }
}
