using System;

public class Scripture
{
    // Attributes (Variables) (Fields)
    private Random random = new Random();
    private List<Word> _words = new List<Word>();
    private Reference _reference;

    public Scripture(List<Word> words, Reference reference)
    {
        _words = words;
        _reference = reference;
    }
    public Scripture(string text)
    {
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word wordObj = new Word(word);
            _words.Add(wordObj);
            // Text to write out the entire scripture (hardcode it)
        }
    }

    public Scripture()
    {

    }

    public void ShowWords()
    {
        Console.WriteLine(_reference);
        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
    }

    public void HidesWords()
    {
        // Pick a random word
        // Call the method to hide the words here
        int index = random.Next(0, _words.Count);
        foreach (Word word in _words)
        {
            _words[index].IsHidden();
        }
    }

    public bool IsCompletelyHidden()
    {
            // loop through the list of words and check if there is a word still visible
            // if so return false
            // else return true
            foreach (Word word in _words)
            {
                if (word.GetHidden() == false)
                {
                    return false;
                }
            }
            return true;
    }
}