using System.ComponentModel;
using System.Globalization;

public class Scripture
{
    private Reference _reference;//this is saving the references.
    private List<Word> _words = new List<Word>();//this list will storage all the word objects.
    

    // this constructor will separate each word from a string to send it to the _words list.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(' ',',', ';', '.', ':');

        foreach(string word in words)
        {
            if (word == "")
            {
                
            }
            else
            {
                Word word1 = new Word(word);
                _words.Add(word1);
            }
        }
    }


// this method will make sure to hide the words that are store in the _words list.
    public void HideRandomWords(int numberToHide)
    {
         int cycle = 0;
         foreach (Word w in _words)
         {
            cycle = cycle + 1;
         }
        
        for (int i = 1; i <= numberToHide; )
        {
            Random random = new Random();
            int randomNumber = random.Next(0, cycle);

            if (_words[randomNumber].IsHidden() == false)
            {
                _words[randomNumber].Hide();
                i++;
            }
        }

    }


// The GetDisplayText is going to display both the reference and the scripture.
    public void GetDisplayText()
    {
        
        Reference reference = new Reference("John", 17, 3);
        Console.WriteLine($"{reference.GetDisplayReference()} {_words[0].GetText()} {_words[1].GetText()} {_words[2].GetText()} {_words[3].GetText()} {_words[4].GetText()}, {_words[5].GetText()} {_words[6].GetText()} {_words[7].GetText()} {_words[8].GetText()} {_words[9].GetText()} {_words[10].GetText()} {_words[11].GetText()} {_words[12].GetText()} {_words[13].GetText()}, {_words[14].GetText()}");
        Console.WriteLine($"{_words[15].GetText()} {_words[16].GetText()}, {_words[17].GetText()} {_words[18].GetText()} {_words[19].GetText()} {_words[20].GetText()}.");
    }


//this method will make sure all if all the words are hidden.
    public bool IsCompletelyHidden()
    {
        int listLenght = 0;
        foreach (Word w in _words)
        {
            listLenght = listLenght + 1;
        }


        bool allWordsAreHidden = false;
        int index = 0;
        while (_words[index].IsHidden() == true)
        {
            if (index == listLenght - 1)
            {
                return allWordsAreHidden = true;
            }
            index++;
        }
        return allWordsAreHidden;
    }
}