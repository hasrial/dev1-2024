Dictionary<string, int> listaSpesa = new Dictionary<string, int>();
listaSpesa.Add("pane", 1);
listaSpesa.Add("latte", 2);

// Aggiugno un nuovo articolo
listaSpesa["uova"] = 12;
// Incrementa la quantià di un articolo gia presente
listaSpesa["pane"] = listaSpesa["pane"] + 1;

foreach (KeyValuePair<string, int> articolo in listaSpesa)
{
    Console.WriteLine($"Articolo: {articolo.Key}, Quantità: {articolo.Value}");
}
