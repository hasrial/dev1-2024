﻿var numeri = new List<int> { 1, 2, 3, 4, 5 };

foreach (var numero in numeri)
{
    Console.WriteLine(numero);
}

//utiliazziamo var perche non sappiamo il tipo di dato che contiene la lista
// ad esempio se fosse una lista di stringhe avremmo dovutoscrivere List<string> numeri = new List<string> { "1", "2", "3", "4", "5" };
// oppure List<int> numeri = new List<int> { 1, 2, 3, 4, 5 };
// invece utilizzando var il compilatore capisce da solo il tipo di dato 
// inoltre possiamo utilizzare var amcje per i tipi anonimi
// ad esempio var persona = new { Nome = "Mario", Cognome = "Rossi" };
// in questo caso il tipo di dato è anonimo perchè non è stato dichiarato eslicitamente
// ma il compilatore capisce che persona è un oggeto con due propietà Nome e Cognome di tipo stringa
// quindi possiamo scrivere persona.Nome o persona.Congome
// inoltre possiamo utilizzare var anche per i tipi generici
// ad esmepio var numeri = new List<int> { 1, 2, 3, 4, 5 };
