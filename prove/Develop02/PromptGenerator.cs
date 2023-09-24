public class PromptGenerator
{
    public List<string> _prompts = new List<string>();//the _prompts list stores the prompts.


    // this method reads information from a file and stores it to the _prompts list.
    public List<string> ReadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            
            _prompts.Add(line);
        }
        return _prompts;
    }


    //the GetRandomPrompt gets one randomize prompt from the list.
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 7);
        string prompt = _prompts[randomNumber];

        return prompt;
    }
}