using System;

public class Reference
{
    private int _chapter;
    private string _book;
    private int _startVerse;
    private int _endVerse;


    public Reference(string book, int chapter, int startVerse)
    {
        _chapter = chapter;
        _book = book;
        _startVerse = startVerse;
    }
    public Reference(string _book, string chapter, string startVerse, int endVerse)
    {
        _endVerse = endVerse;
    }

    public Reference()
    {

    }

    public string FormatReference()
    {
        return $"{_book} {_chapter} {_startVerse}";
    }

    // public void Display()
    // {
    //     Console.WriteLine(_chapter);
    //     Console.WriteLine(_book);
    //     Console.WriteLine(_startVerse);
    // }
}