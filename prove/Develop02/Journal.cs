using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _fileName;
    public List<Entry> _entries = new List<Entry>();
    public DateTime _date = DateTime.Now;

    // Saving to a file
    public void SaveToFile()
    {
        string file = _fileName;
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry q in _entries)
            {
                outputFile.WriteLine(q._date);
                outputFile.WriteLine(q._prompt);
                outputFile.WriteLine(q._userData);
            }
        }
    }
    // Loading from a file
    public void ReadFromFile()
    {
        string file = _fileName;
        string[] lines = System.IO.File.ReadAllLines(file);

        int side = lines.Length;
        side = side - 1;

        int d = 0;
        int p = 1;
        int a = 2;

        for (int f = 0; f <= side; f = f + 3)
        {
            Entry entry = new Entry();
            entry._date = lines[d];
            entry._prompt = lines[p];
            entry._prompt = lines[a];

            d = d + 3;
            p = p + 3;
            a = a + 3;
            _entries.Add(entry);
        }
        Console.WriteLine("Journal Load Successful!");
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display1Entry();
        }
    }
}