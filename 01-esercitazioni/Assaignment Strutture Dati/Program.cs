/*
List<string> nomi = new List<string>();                 // dichiarazione di una lista di stringhe

    nomi.Add("Silvano");
    nomi.Add("Allison");
    nomi.Add("Daniele");
    nomi.Add("Serghej");
    nomi.Add("Matteo");
    nomi.Add("Charon");
    nomi.Add("Mattia");
    Random random = new Random();                       // questo è un costruttore ovvero un codice che ci permette di generare a random un determinato dato
    while (nomi.Count > 0)
{
    int indice = random.Next(nomi.Count);               // generazione di un numero casuale tra 0 e il numero di elementi della lista
    Console.WriteLine($"Sorteggiato {nomi[indice]}");   // visualizzazione del nome sorteggiato
    nomi.RemoveAt(indice);                              // rimozione del nome dalla lista
    Console.WriteLine("Elenco partecipanti");           //visualizzazione dell'elenco dei partecipanti
    foreach (string nome in nomi)                       // per ogni stringa della lista
    {
        Console.WriteLine(nome);
    }
}
*/

/*
List<string> nomi = new List<string>();                         // genero la lista dei partecipanti e aggungo i vari nami
    nomi.Add("Silvano");
    nomi.Add("Allison");
    nomi.Add("Daniele");
    nomi.Add("Serghej");
    nomi.Add("Matteo");
    nomi.Add("Charon");
    nomi.Add("Mattia");

List<string> sorteggiati = new List<string>();                  // genero la lista dei sorteggiati

Random random = new Random();                                   // genero il costrutto random

while (nomi.Count > 0)
{
    int indice = random.Next(nomi.Count);                       // randomizzo la lista dei partecipanti e il costrutto lo chiamo "indice"
    string sorteggiati = nomi[indice];                          // estrazione del nome sorteggiato
    Console.WriteLine($"Il nome sorteggiato è {nomi[indice]}"); // visualizzazione del nome sorteggiato
    nomi.RemoveAt(indice);                                      // rimozione del nome dal primo elenco
    sorteggiati.Add(sorteggiato);                               // aggiungo il nome sorteggiato alla nuova lista

    Console.WriteLine("Elenco partecipanti:");
    foreach (string nome in nomi)
        {
            Console.WriteLine(nome);
        }
    Console.WriteLine("Elenco sorteggiati:");
    foreach (string nome in sorteggiati)
    {
        Console.WriteLine(nome);
    }    
}
*/


List<string> nomi = new List<string>();
string nome;
int scelta;
do 
{    
    Console.WriteLine ("1. Inserisci partecipante");
    Console.WriteLine ("2. Visualizza partecipante");
    Console.WriteLine ("3. Ordina partecipanti");
    Console.WriteLine ("4. Esci");
    Console.WriteLine ("Scelta: ");
    scelta = Convert.ToInt32(Console.ReadLine());
switch (scelta)
{
case 1:
    Console.Write("Nome partecipante: ");
    nome = Console.ReadLine();
    nomi.Add(nome);
    break;
case 2:
    Console.WriteLine("Elenco partecipanti:");
    foreach (string nom in nomi)
        {
            Console.WriteLine(nom);
        }
    break;
case 3:
    Console.WriteLine ("Vuoi ordinare in ordine alfabetico discendente o ascendente? D/A");
    string lettera;
    lettera = Console.ReadLine().ToLower();
   
    if (lettera == "d")
    {
        nomi.Sort();
        foreach (string nom in nomi)
        {
            Console.WriteLine(nom);
        }
    }    
    else if (lettera == "a")
    {
            nomi.Reverse();
            foreach (string nom in nomi)
            {
                Console.WriteLine(nom);
            }
    }
    else
        {
            Console.WriteLine ("Scelta non valida");
        }
break;
case 4:
Console.WriteLine ("Alla prossima");
    break;
default:
    Console.WriteLine("Scelta non valida");
    break;
}
}
while (scelta !=4); // il ciclo continua finchè la seclta è divera da 4