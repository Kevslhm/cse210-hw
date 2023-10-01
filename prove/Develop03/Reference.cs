public class Reference
{
    // Here I created some member variables to store necesary information for a reference.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


// This construtors will set our member varibles with a diferent value. and it has 3 to 4 arguments
// to set.
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }



// This method will return all the reference information like string.
    public string GetDisplayReference()
    {
        return _book + " " + _chapter.ToString() + ":" + _verse.ToString() + "-" + _endVerse.ToString();
    }
}