using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator myPrompt = new PromptGenerator();
        Journal myJournal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("===== Welcome to the virtual Journal Program! =====");
            Console.WriteLine("Please select a choice listed below: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What is your choice?");
            string _input = Console.ReadLine();

            switch (_input)
            {
                case "1":
                    Entry myEntry = new Entry();
                    myEntry._date = myPrompt.GetDate();
                    myEntry._prompt = myPrompt.GetPrompt();
                    Console.Write(myEntry._prompt);
                    myEntry._userData = Console.ReadLine();
                    myJournal._entries.Add(myEntry);
                    break;
                case "2":
                    myJournal.DisplayEntries();
                    break;
                case "3":
                    myJournal.ReadFromFile();
                    break;
                case "4":
                    Console.Write("Please give this file a name: ");
                    myJournal._fileName = Console.ReadLine();
                    myJournal.SaveToFile();
                    Console.WriteLine("Journal saved!");
                    break;
                case "5":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("That option is invalid. Please try again.");
                    break;
            }
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for using the Journal Program! Good-bye for now!");
    }

}