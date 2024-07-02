Dictionary<string, List<int>> registroClassi = new Dictionary<string, List<int>>();
registroClassi["Marco"] = new List<int> {7, 8, 9};
registroClassi["Luca"] = new List<int>{6, 7, 8};

//aggiungo un nuovo voto
registroClassi["Marco"].Add(10);
//stampa di tutti gli studenti e i loro voti
foreach (var studente in registroClassi)
{
    Console.WriteLine($"Studente: {studente.Key}, Voti: {string.Join(", ", studente.Value)}"); //string.Join unisce gli elemti di una sequenza in un string
}