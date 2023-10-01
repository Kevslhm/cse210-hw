public class Word
{
    // Here a created 3 member variables to store a word, to check if a word is hidden or not,
    private string _text;
    private bool _isHidden;
    private string _guiones;                 

    // This constructor will only assign values for our member variables.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // This method is going to hide the words
     public void Hide()
    {
        foreach(char l in _text)
        {
            _guiones = _guiones + "_";
        }
        _text = _guiones;
        _isHidden = true;
        
    }
    // This one will show a word if needed.
    public void Show()
    {
        foreach(char l in _text)
        {
            Console.Write(l.ToString());
        }

        _isHidden = false;
    }

    // This method will return the _isHidden varible.
    public bool IsHidden()
    {
        return _isHidden;
    }


// This one will return the _text variable.
    public string GetText()
    {
        return _text;
    }

}