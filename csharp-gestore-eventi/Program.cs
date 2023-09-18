using csharp_gestore_eventi;

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

    Console.WriteLine($"Evento creato con successo: {evento}");

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
}
catch (Exception ex)
{
    Console.WriteLine("Errore: " + ex.Message);
}

