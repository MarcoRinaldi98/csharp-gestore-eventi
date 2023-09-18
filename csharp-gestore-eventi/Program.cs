using csharp_gestore_eventi;

try
{
    // chiedo all'utente di inserire il nome del suo programma di eventi
    Console.Write("Inserisci il titolo del tuo programma eventi: ");
    string titoloProgramma = Console.ReadLine();

    // creo il programma di eventi con il nome inserito dall'utente
    ProgrammaEventi programma = new ProgrammaEventi(titoloProgramma);

    // chiedo all'utente quanti eventi vuole aggiungere all'interno del programma creato
    Console.Write("Quanti eventi vuoi aggiungere? ");
    int numeroEventiDaAggiungere = int.Parse(Console.ReadLine());

    for (int i = 0; i < numeroEventiDaAggiungere; i++)
    {
        try
        {
            // definisco i dati dell'evento chiedendoli all'utente
            Console.Write("Inserisci il nome dell'evento: ");
            string titolo = Console.ReadLine();

            Console.Write("Inserisci la data dell'evento (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.Write("Inserisci il numero di posti totali: ");
            int postiMassimi = int.Parse(Console.ReadLine());

            // istanzio l'evento con i dati precedentemente passati dall'utente
            Evento evento = new Evento(titolo, data, postiMassimi);

            // inserisco l'evento creato nel programma
            programma.AggiungiEvento(evento);
            Console.WriteLine($"Evento creato con successo: {evento}");
        } 
        catch (Exception ex)
        {
            // se qualcosa dovesse andare storto visualizzo messaggio di errore e faccio ripetere l'inserimento all'utente
            Console.WriteLine("Errore nell'aggiunta dell'evento: " + ex.Message);
            i--;
        }
    }
    // Stampo a schermo il numero di eventi presenti nel programma
    Console.WriteLine($"Numero di eventi nel programma: {programma.NumeroDiEventi()}");

    // Stampo la lista di eventi per il programma
    Console.WriteLine("Ecco il tuo programma eventi:");
    Console.WriteLine(programma.ElencoEventiPerProgramma());

    // Chiedo all'utente una data e stampo a schermo tutti gli eventi per quella data
    Console.Write("Inserisci una data per sapere che eventi ci saranno (dd/MM/yyyy): ");
    DateTime dataRicerca = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
    List<Evento> eventiTrovati = programma.TrovaEventiPerData(dataRicerca);
    if (eventiTrovati.Count > 0)
    {
        Console.WriteLine(ProgrammaEventi.StampaEventi(eventiTrovati));
    } else
    {
        Console.WriteLine("Non ci sono eventi per la data inserita!");
    }
    

    // Elimino tutti gli eventi dal programma
    programma.SvuotaEventi();
    Console.WriteLine("Tutti gli eventi sono stati eliminati dal programma!");
}
catch (Exception ex)
{
    Console.WriteLine("Errore: " + ex.Message);
}

/*
while (true)
{
    // chiedo all'utente se vuole effetturare prenotazione posti
    Console.Write("Vuoi prenotare posti? (si/no): ");
    string risposta = Console.ReadLine();
    if (risposta.ToLower() == "si" || risposta.ToLower() == "s")
    {
        // SE si chiedo la quantità di posti da prenotare e ne verifico la disponibilità
        Console.Write("Quanti posti desideri prenotare? ");
        int quantitaPrenotazione = int.Parse(Console.ReadLine());

        evento.PrenotaPosti(quantitaPrenotazione);

        Console.WriteLine($"Numero di posti prenotati = {evento.NumeroPostiPrenotati}");
        Console.WriteLine($"Numero di posti disponibili = {evento.NumeroPostiMassimi - evento.NumeroPostiPrenotati}");
    }
    else
    {
        // ALTRIMENTI visualizzo messaggio a schermo e vado oltre
        Console.WriteLine("OK va bene!");
        break;
    }
}

while (true)
{
    // chiedo all'utente se vuole disdire posti prenotati
    Console.Write("Vuoi disdire dei posti? (si/no): ");
    string risposta = Console.ReadLine();
    if (risposta.ToLower() == "si" || risposta.ToLower() == "s")
    {
        // SE si chiedo la quantità di posti da disdire e ne verifico la possibilità 
        Console.Write("Indica il numero di posti da disdire: ");
        int quantitaDisdetta = int.Parse(Console.ReadLine());

        evento.DisdiciPosti(quantitaDisdetta);

        Console.WriteLine($"Numero di posti prenotati: {evento.NumeroPostiPrenotati}");
        Console.WriteLine($"Numero di posti disponibili: {evento.NumeroPostiMassimi - evento.NumeroPostiPrenotati}");
    }
    else
    {
        // ALTRIMENTI visualizzo messaggio a schermo e vado oltre
        Console.WriteLine("OK va bene!");
        break;
    }
}
*/