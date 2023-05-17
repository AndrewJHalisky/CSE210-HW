using System;
public class Entry
{
    public string _userData;
    public string _prompt;
    public string _input;
    public DateTime _date;

    public string Display1Entry()
    {
        Console.WriteLine(_userData);
        return _userData;
        // Display the Entries from the user here.
    }
}