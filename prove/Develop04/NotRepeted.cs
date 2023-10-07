public class NotRepeated
{
    private bool _hasBeenUsed;
    private string _question;

    public NotRepeated(bool hasBeenUsed, string question)
    {
        _hasBeenUsed = hasBeenUsed;
        _question = question;
    }

    public bool GetHasBeenUsed()
    {
        return _hasBeenUsed;
    }

    public string GetQuestion()
    {
        return _question; 
    }

    public void ChangeState()
    {
        _hasBeenUsed = true;
    }
}