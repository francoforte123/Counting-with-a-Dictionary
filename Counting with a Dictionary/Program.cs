Console.Write("inserisci un percorso di un file txt: ");
string Path = Console.ReadLine();

Dictionary<string, int> DictionaryList = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

string ContentFile= File.ReadAllText(Path);

Console.WriteLine("\nil contenuto del file di testo è: " + ContentFile);

int CounterWord = 0;
string[] ArrayWord = ContentFile.Split(new char[] {' ', '\t', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);

foreach(string word in ArrayWord)
{
    if(DictionaryList.ContainsKey(word)) CounterWord+=1;
    else { DictionaryList[word] = 1; }
}

Console.WriteLine("frequenza delle parole:");

foreach(var pair in DictionaryList)
{
    Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
}


