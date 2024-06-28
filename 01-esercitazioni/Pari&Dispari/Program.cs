// versione semplificata del gioco pari o dispari

Random random = new Random(); 
int numeroComputer = random.Next(1, 11);

Console.Write("Scegli Pari o Dispari (P/D): ");

string scelta = Console.ReadLine().ToUpper(); 

if ((numeroComputer % 2 == 0 && scelta == "P") || (numeroComputer % 2 != 0 && scelta == "D"))
{
    Console.WriteLine($"Il Computer ha scelto {numeroComputer}. Hai vinto!");
}
else
{
    Console.WriteLine($"Il computer ha scelto {numeroComputer}. Hai perso!");
}
