//ho modifocato tutto il programma ma non ho altre alternativr/scelta su cosa modificare

Console.WriteLine("inserisci il percorso completo del file txt:");
string filePath = Console.ReadLine();

Dictionary<string, int> wordCounts = CountWords(filePath);

Console.WriteLine("frequenze di parole:");
foreach (var word in wordCounts)
{
     Console.WriteLine(word.Key + " " + word.Value);
}

static Dictionary<string, int> CountWords(string filePath){
    string text = File.ReadAllText(filePath);
    string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

    Dictionary<string, int> wordCounts = new(StringComparer.OrdinalIgnoreCase);

    foreach (string word in words){

        if (wordCounts.ContainsKey(word)){
            wordCounts[word]++;
        }
        else{
         wordCounts[word] = 1;
        }
    }
    return wordCounts;
}


