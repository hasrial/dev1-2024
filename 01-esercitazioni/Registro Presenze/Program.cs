Dictionary<string, bool> presenze = new Dictionary<string, bool>();
presenze["Mario Rossi"] = true;
presenze["Luca Bianchi"] = false;

foreach (KeyValuePair<string, bool> dipendente in presenze)
{
    if (dipendente.Value)
    {
        Console.WriteLine("Dipendente: " + dipendente.Key + ", Stato: Presente");
    }
    else
    {
        Console.WriteLine("Dipendente " + dipendente.Key + ", Stato: Assente");
    }
}

Console.WriteLine("Di quale dipendente vuoi comabiare lo stato?");

string nomeDipendente = Console.ReadLine();

 if (presenze.ContainsKey(nomeDipendente))
 {
    presenze[nomeDipendente] = !presenze[nomeDipendente]; //Cambio lo stato del dipendete (quando viene richiamto il primo valore presenza[nomeDipendete] il codice restituisce il contrario)
 }
 else
 {
    Console.WriteLine("Il dipendete non è presente nella lista");
 }
// Stampo la lista aggiornata

foreach (KeyValuePair<string, bool> dipendente in presenze)
{
    if (dipendente.Value) 
    {
        Console.WriteLine("Dipendetne: " + dipendente.Key + ", Stato: Presente");
    }
    else 
    {
        Console.WriteLine("Dipendetne: " + dipendente.Key + ", Stato: Assente");
    }
}