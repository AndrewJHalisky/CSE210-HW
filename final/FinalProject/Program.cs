using System;

class Program
{
    static void Main(string[] args)
    {
        File IO = new File();
        List<VideosGames> _shoppingList = new List<VideosGames>();
        bool exit = false;
        while(!exit)
        {
            Console.WriteLine();
            Console.WriteLine("=============Welcome to Marvin's Movies and Games Inc==============");
            Console.WriteLine("The best shopping spot for movies and video games of your choice!");
            Console.WriteLine("Looking for videos and entertainment? We got it all right here!");
            Console.WriteLine();
            Console.WriteLine("Select a choice from the menu: ");
            Console.WriteLine("1. Purchase Items");
            Console.WriteLine("2. Display Purchases List");
            Console.WriteLine("3. Save Purchases List");
            Console.WriteLine("4. Load Purchases List");
            Console.WriteLine("5. Remove an Item");
            Console.WriteLine("6. Proceed to checkout");
            Console.WriteLine("7. Quit");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                {
                    break;
                }
                case "2":
                {
                    break;
                }
                case "3":
                {
                    break;
                }
                case "4":
                {
                    break;
                }
                case "5":
                {
                    break;
                }
                case "6":
                {
                    break;
                }
                case "7":
                {
                    Console.WriteLine("=============Marvin's Movies and Games Inc============");
                    Console.WriteLine("Thank you for shopping with us today! Goodbye for now!");
                    exit = true;
                    break;
                }
            }
        }
    }
}