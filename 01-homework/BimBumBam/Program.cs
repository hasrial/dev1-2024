﻿// gioco Bim Bum Bam

Console.Write("Scegli Pari o Dispari (P/D): ");

string scelta = Console.ReadLine().ToUpper();

Random random = new Random();
int numeroComputer = random.Next(0, 5);

Console.Write("Inserisci il tuo numero: ");
int numero1 = Convert.ToInt32(Console.ReadLine());
bool sommaPari = (numero1 + numeroComputer) % 2 == 0;

if ((sommaPari && scelta == "P") || (!sommaPari && scelta == "D"))
 {
    Console.WriteLine("Hai Vinto"); 
 }
else 
{
    Console.WriteLine("Hai Perso");
}