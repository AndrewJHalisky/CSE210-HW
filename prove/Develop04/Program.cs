using System;
using System.IO;

class Program{
    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Mindfulness program! Select one of the three choices listed below.");
            Console.WriteLine("1. Breathing activity");
            Console.WriteLine("2. Reflecting activity");
            Console.WriteLine("3. Listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            string user = Console.ReadLine();

            switch (user)
            {
                case "1":
                    BreathActivity breathAct = new BreathActivity(
                        "Welcome to the Breathing Activity!", 
                        "This activity will help you relax by making you breathe in and breathe out slowly. If you are feeling panicked or worried, clear your mind and focus on breathing!",
                        "Well done!! You have completed the Breathing Activity!"
                    );
                    Console.WriteLine(breathAct.GetAnimation());
                    Console.WriteLine(breathAct.GetStartMessage());
                    Console.WriteLine(breathAct.GetBreathDescrpt());
                    Console.Write(breathAct.Breathe());
                    Console.WriteLine(breathAct.GetEndMessage());
                    Console.WriteLine(breathAct.Ending());
                    break;
                case "2":
                    ReflectActivity reflectAct = new ReflectActivity(
                        "Welcome to the Reflecting Activity!",
                        "This activity will help you reflect on times when you have shown strength in yourself and towards others",
                        "This activity is good for looking back at your old self and see how much you have changed.",
                        "Well done! You have completed the Reflecting Activity!"
                    );
                    Console.WriteLine(reflectAct.GetAnimation());
                    Console.WriteLine(reflectAct.GetStartMessage());
                    Console.WriteLine(reflectAct.GetReflectDescrpt1());
                    Console.WriteLine(reflectAct.GetReflectDescrpt2());
                    Console.Write(reflectAct.Reflect());
                    Console.WriteLine(reflectAct.GetEndMessage());
                    Console.Write(reflectAct.Ending());
                    break;
                case "3":
                    ListActivity listAct = new ListActivity(
                        "Welcome to the Listing Activity!",
                        "This activity will help you remember the good times in your life by listing them for a certain duration of time.",
                        "Well done! you have completed the Listing Activity!"
                    );
                    Console.WriteLine(listAct.GetAnimation());
                    Console.WriteLine(listAct.GetStartMessage());
                    Console.WriteLine(listAct.GetListDscrpt());
                    Console.Write(listAct.Listing());
                    Console.Write(listAct.Ending());
                    Console.WriteLine(listAct.GetEndMessage());
                    Console.Write(listAct.Ending());
                    break;
                case "4":
                    Console.WriteLine("Thanks for exercising your mind! Goodbye for now!");
                    exit = true;
                    break;
                default:
                    Console.WriteLine("That choice is not valid. Please pick a valid number.");
                    exit = false;
                    continue;
            }
        }
        
    }
}