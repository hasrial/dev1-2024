# ELENCO COMPAGNI DI CORSO CON SORTEGGIO
## v.1

Creare una console app che contiene un elenco di nomi dei parteipanti del cosro
L'app sorteggia un nome e lo visualizza.

```csharp
List<string> nomi = new List<string>();
    nomi.Add("Silvano");
    nomi.Add("Allison");
    nomi.Add("Daniele");
    nomi.Add("Serghej");
    nomi.Add("Matteo");
    nomi.Add("Charon");
    nomi.Add("Mattia");
    nomi.Add("Ginevra");

    Random random = new Random();
  int indice = random.Next(nomi.Count);
  
    Console.WriteLine($"il/la fortunato/a è {nomi[indice]}");
```
```csharp
// si possono inserire più nomi in contemporanea invece di uno alla volta cosi:
nomi.AddRange(new string[]{"Mario", "Luigi", "Giovanni"});
// oppure cosi;
List<string> nomi = new List<string> {"Mario", "Luigi", "Giovanni"};
```
// il metodo RemoveAt(indice) ci permette di elimare il nome che è stato estratto prima

## v.2
Creare una console app che contiene un elenco di nomi dei parteipanti del cosro
L'app sorteggia un nome e lo visualizza.
L'app toglie dalla lista il nome sorteggiato
L'app visualizza la lista dei nomi rimanenti

## v.3
Creare una console app che contiene un elenco di nomi dei parteipanti del cosro
L'app sorteggia un nome e lo visualizza.
L'app toglie dalla lista il nome sorteggiato
L'app visualizza la lista dei nomi rimanenti
L'app continua a sorteggiare finchè ci sono nomi nella lista

## v.4
Creare una console app che contiene un elenco di nomi dei parteipanti del cosro
L'app sorteggia un nome e lo visualizza.
L'app toglie dalla lista il nome sorteggiato
L'app visualizza la lista dei nomi rimanenti
L'app sposta i nomi dalla lista elenco e dopo aver sorteggiato il nome lo esporta in un altra lista
