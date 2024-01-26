public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
         if (_entries.Count > 0)
        {
            foreach (var entry in _entries)
            {
                entry.Display();
            }
        }
        else
        {
            Console.WriteLine("No entries found.");
        }
    }
    public void SaveToFile(string filepath)
    {
        Console.WriteLine("Saving to file....");
        using (StreamWriter outputFile = new StreamWriter(filepath))
        {
            foreach (Entry entry in _entries)
            {
                
                outputFile.WriteLine($"{entry._date}-{entry._promptText}-{entry._entryText}");
            }
        }

    }
    public void LoadFromFile(string filepath)
    {
        Console.WriteLine("Reading from file...");
        Entry retEntry = new Entry();
        string[] lines = System.IO.File.ReadAllLines(filepath);
         
         foreach (var line in lines)
        {   
            string[] parts = line.Split("-");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);
        }
    }
}