using System;
using System.IO;

class Journal
{
    public List<Entry> _entries;
    public Journal ()
    {
        _entries = new List<Entry>();
    }

    public void CreateEntry(Entry entry) {
        _entries.Add(entry);
    }

    public void ShowEntries(){
        if (_entries.Count == 0){
            Console.WriteLine("No Entries");
        }
        else{
            foreach (Entry entry in _entries){
                Console.WriteLine(entry.GetEntry());
            }
        }
    }
    
    public void SaveJournal(string filename) {
        using (StreamWriter outputFile = new StreamWriter(filename, true)) {
            foreach (var entry in _entries){
                outputFile.WriteLine(entry.GetEntry());
            }     
        }
    }
    
    public void LoadJournal(string filename) {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines) {
            string[] parts = line.Split(",");
            

            // IDEAS FROM TREVOR
            // for loop which increments by 3
            int numEntries = parts.Length / 3;         // do calculation here
            for (int i = 0; i < numEntries; i += 3) {
                // parse the array
                string date = parts[i];
                string prompt = parts[i + 1];
                string text = parts[i + 2];
                Entry newEntry =  new Entry(text, prompt);
                // Add entry to the file
                _entries.Add(newEntry);
            }

            // debug
            string test1 = parts[0];
            // string test2 = parts[1];
            // string test3 = parts[2];
            Console.WriteLine(test1);
        }
    }
}