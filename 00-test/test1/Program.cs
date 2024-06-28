// il coomento multilinea si fa cosi:

/*
Console.WriteLine("commento");
Console.WriteLine("commento");
*/

/*
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");  
Console.WriteLine("a capo \n");  // il carattere \n serve per andare a capo
Console.WriteLine("tabulazione \t");  // il carattere \t serve per tabulare


Console.WriteLine("Preme un tasto per terminare...");   // stampa a video la stringa "Premere un tato per terminare..."
// Console.ReadKey();  // attende la pressione di un tasto da parte dell'utente

string nome = Console.ReadLine(); // legge una stringa da testiera e la memorizza nella variabile nome
string? nome = Console.ReadLine(); // legge una stringa da tastiera e la memorizza nella variabile nome senza mostrare il messaggio di warning!
string nome = Console.ReadLine()!; // legge una stringa da tastiera e la memorizza nella variabile nome senza mostrare il messaggio di warning!


Console.WriteLine("Insert Name");    // stampa a video il contenuto della variabile nome
Console.WriteLine("Hello, " + nome + "!"); // stampa a video la stringa "Hello, " concatenata con il contenuto
// Console.WriteLine($"Hello, {nome}!"); // il simbolo del dollaro "$" atitva la intepolazione che permette di concatenare la stringa con tutto quello che si trova tra le parentesi graffe fino al !
Console.WriteLine($"Hello, {nome}!");
string cognome = "Grioli"; // dichiarazione e iniziallizazione di una variabile di 
*/

//Console.WriteLine("Ciao, premere un tasto per continuare...");
//Console.ReadKey();
Console.Write("Inserire nome...");
string? nome = Console.ReadLine();
string cognome = "Grioli";
Console.WriteLine($"Ciao, {nome} {cognome}!");
