List<string> nomi = new List<string>();
    nomi.Add("Mario");
    nomi.Add("Luigi");
    nomi.Add("Giovanni");
    nomi.Add("Ginevra");
    Console.WriteLine($"Ciao {nomi[0]}, {nomi[1]} e {nomi[2]}");
    Console.WriteLine($"Il numero di elementi è {nomi.Count}");

    /* il quarto nome "Ginevra" non verra mostrato poiche non è specificato nel writeLine tuttavia il nome è comunque aggiunto alla lista.
    Infatti in questo caso quando faremo partire la nostra app ci mostrerà i 3 nomi ma ne conterà 4
    */