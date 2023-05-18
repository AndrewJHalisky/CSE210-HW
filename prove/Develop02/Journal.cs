using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _file;

    public List<Entry> _entries = new List<Entry>();
    public DateTime _date = DateTime.Now;

    // Saving to a file
    public void SaveToFile(List<Entry> _entries)
    {
        Console.WriteLine("Saving to file....");
        string fileName = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry q in _entries)
            {
                outputFile.WriteLine(_date);
                outputFile.WriteLine();
                outputFile.WriteLine(q._prompt);
                outputFile.WriteLine(_entries);
            }
        }
    }
    // Loading from a file
    public List<Entry> ReadFromFile()
    {
        Console.WriteLine("Loading list from file...");
        string fileName = "journal.txt";

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            // Console.WriteLine(line);
            // Console will write the answer with this.
            string[] parts = line.Split(",");

            Entry _userData = new Entry();
            _entries.Add(_userData);
        }
        return _entries;
    }


    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display1Entry();
        }
    }
}