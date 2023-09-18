using csharp_gestore_eventi;

try
{
    Console.Write("Inserisci il nome dell'evento: ");
    string titolo = Console.ReadLine();

    Console.Write("Inserisci la data dell'evento (dd/MM/yyyy): ");
    DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

    Console.Write("Inserisci il numero di posti totali: ");
    int postiMassimi = int.Parse(Console.ReadLine());

    Evento evento = new Evento(titolo, data, postiMassimi);

    Console.WriteLine($"Evento creato con successo: {evento}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

