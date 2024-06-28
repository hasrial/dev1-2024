/*
FizzBuzz individua i numeri divisibili per 3, 5 e 15

Random random = new Random();
int numeroComputer = random.Next(1, 101);

// dopo aver sorteggiato un numero, bisogna crare uno statmant che prende in condizione tutti i casi, se fosse divisibile per 3,5 o 15... tre condizioni diverse.

Console.WriteLine (numeroComputer);

if (numeroComputer % 3 == 0 && numeroComputer % 5 == 0)
{
    Console.WriteLine ("FizzBuzz");
}
else if (numeroComputer % 5 == 0)
{
    Console.WriteLine ("Buzz");
}
else if (numeroComputer % 3 == 0)
{
    Console.WriteLine ("Fizz");
}
else 
{
    Console.WriteLine (numeroComputer);
}
*/

for(int i = 0; i < 100; i++){
    Console.Write($"Numero |{i}| \t");
    Thread.Sleep(200);
    if(i % 3 == 0) Console.Write($"Fizz");
    if(i % 5 == 0) Console.Write($"Buzz");
    Console.Write("\n");
}
