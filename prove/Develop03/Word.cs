using System;

public class Word
{
    private string _word;
    private bool _hidden;
    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public Word()
    {
        
    }

    public void DisplayWord()
    {
        if (_hidden == true)
        {
            // Console.Clear();
            Console.Write("_____ ");
        }
        else 
        {
            Console.Write($"{_word} ");
        }
    }

    public bool GetHidden()
    {
        return _hidden;
    }

    public void IsHidden()
    {
        _hidden = true;
    }

    public string GetWords()
    {
        return _word;
    }

}