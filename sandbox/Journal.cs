public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry name, Journal journal)
    {

        journal._entries.Add(name);
    }


    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine("");
        }
    }


    public void SaveToFile(List<Entry> _entries, string fileName)
    {
        //string fileName = "Entries.txt";

        using(StreamWriter entryWriter = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                entryWriter.WriteLine($"{e._date}---{e._prompt}---{e._userEntry}");
            }
        }
    }

    public List<Entry> LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("---");
            Console.WriteLine($"Date: {parts[0]} - Prompt: {parts[1]}");
            Console.WriteLine(parts[2]);
            Console.WriteLine("");

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._userEntry = parts[2];

            _entries.Add(entry);
        }

        return _entries;
    }

}