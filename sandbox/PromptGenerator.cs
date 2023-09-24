public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public List<string> ReadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            
            _prompts.Add(line);
        }
        return _prompts;
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 7);
        string prompt = _prompts[randomNumber];

        return prompt;
    }
}