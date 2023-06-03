namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Hardcode the reference in Reference()   // Hardcode the scripture in the ScriptureGenerator()
            Reference newRef = new Reference();
            ScriptureGenerator generate = new ScriptureGenerator();
            string scrpt = generate.GenerateScripture();
            string refer = generate.GenerateChapter();
            Scripture newScrpt = new Scripture(scrpt);
            Scripture newChap = new Scripture(refer);
            bool exit = false;
            Console.WriteLine("Welcome to the scripture memorizer program!");
            Console.WriteLine("Press enter to generate a scripture. Type quit to exit the program.");
            while (!exit)
            {
                Console.WriteLine();
                string user = Console.ReadLine();
                    
                    newChap.ShowWords();
                    newScrpt.ShowWords();
                    newScrpt.HidesWords();
                    Console.WriteLine();
                    Console.WriteLine("Press enter again to memorize the scripture. Type quit to exit the program.");
                    
                    if (user == "quit")
                    {
                        Console.WriteLine("Thanks for playing! Goodbye for now!");
                        exit = true;
                    }
                } 
            }
    }
}