public class Journal
{
    public List<Entry> _entries = new List<Entry>();//Here is where all the Entry's objects are going to be 
    //stored.

    
    //this AddEntry method will add a Entry object to the _entries list that is above.
    public void AddEntry(Entry name, Journal journal)
    {

        journal._entries.Add(name);
    }


    //this method is incharge of display the entry's information that is stored in a list<Entry>.
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine("");
        }
    }


    //this method is incharge to save all the entries objects to a file.
    public void SaveToFile(List<Entry> _entries, string fileName)
    {

        using(StreamWriter entryWriter = new StreamWriter(fileName))
        {
            foreach (Entry e in _entries)
            {
                entryWriter.WriteLine($"{e._date}---{e._prompt}---{e._userEntry}");
            }
        }
    }

    //this method will read a file and stores the information obtained to a list. 
    public List<Entry> LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("---");
           

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._prompt = parts[1];
            entry._userEntry = parts[2];

            _entries.Add(entry);
        }

        return _entries;
    }

}