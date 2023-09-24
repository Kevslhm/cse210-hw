public class Entry
{
    public string _date;
    public string _prompt;
    public string _userEntry;


    //this Display method shows the Entry's information the the properties.
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine(_userEntry);
    }
}