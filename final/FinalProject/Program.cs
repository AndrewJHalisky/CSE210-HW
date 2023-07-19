class Program
{
    static void Main(string[] args)
    {
        File IO = new File();
        List<VideosGames> _shoppingList = new List<VideosGames>();
        bool exit = false;
        int _totalPrice = 0;
        while (!exit)
        {
            Console.WriteLine();
            Console.WriteLine("=============Welcome to Marvin's Movies and Games Inc==============");
            Console.WriteLine("The best shopping spot for all of your movies and video games!");
            Console.WriteLine("Looking for videos and entertainment? We got it all right here!");
            Console.WriteLine();
            Console.WriteLine("Select a choice from the menu: ");
            Console.WriteLine("1. Purchase Items");
            Console.WriteLine("2. Display Purchases List");
            Console.WriteLine("3. Save Purchases List");
            Console.WriteLine("4. Load Purchases List");
            Console.WriteLine("5. Proceed to checkout");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                {
                    Console.WriteLine("What are you interested in purchasing? ");
                    Console.WriteLine("1. Video Games ");
                    Console.WriteLine("2. Video Game System ");
                    Console.WriteLine("3. Video Game Equipment ");
                    Console.WriteLine("4. Movies or Shows Discs ");
                    Console.WriteLine("5. Movies or Shows for Digital devices ");
                    Console.WriteLine("6. Disc player "); 
                    Console.Write("Select a choice from the menu: ");
                    string type = Console.ReadLine();
                    switch (type)
                    {
                        case "1":
                        {
                            Console.Write("What is the name of the video game you are purchasing? ");
                            string _purchaseTitle = Console.ReadLine();
                            Console.Write("What system is this video game being purchased for? ");
                            string _purchaseSystem = Console.ReadLine();
                            Console.Write("What is the price of this video game purchase? ");
                            int _purchasePrice = int.Parse(Console.ReadLine());
                            Console.Write("What is the category of this video game purchase? ");
                            string _gameCategory = Console.ReadLine();
                            Games videoGame = new Games(_purchaseTitle, _purchaseSystem, _purchasePrice, _gameCategory);
                            _shoppingList.Add(videoGame);
                            break;
                        }
                        case "2":
                        {
                            Console.Write("What genre or company is this system part of? ");
                            string _purchaseTitle = Console.ReadLine();
                            Console.Write("What is the name of the video game system that you are purchasing? ");
                            string _purchaseSystem = Console.ReadLine();
                            Console.Write("What is the price of this system purchase? (Usually not less than $100) ");
                            int _purchasePrice = int.Parse(Console.ReadLine());
                            Console.Write("How many months would you like to put in for a warranty? ");
                            int _systemWarranty = int.Parse(Console.ReadLine());
                            Console.Write("What is the category of this video game purchase? ");
                            string _systemCategory = Console.ReadLine();
                            GameSystems gameSystem = new GameSystems(_purchaseTitle, _purchaseSystem, _purchasePrice, _systemWarranty, _systemCategory);
                            _shoppingList.Add(gameSystem);
                            break;
                        }
                        case "3":
                        {
                            Console.Write("What is the name of the item that you are purchasing? ");
                            string _purchaseTitle = Console.ReadLine();
                            Console.Write("What system is this item being purchased for? ");
                            string _purchaseSystem = Console.ReadLine();
                            Console.Write("What is the price of this item? ");
                            int _purchasePrice = int.Parse(Console.ReadLine());
                            Console.Write("What type of item is this? ");
                            string _equipType = Console.ReadLine();
                            Console.Write("What is the category of this video game purchase? ");
                            string _equipCategory = Console.ReadLine();
                            GameEquipment gameEquip = new GameEquipment(_purchaseTitle, _purchaseSystem, _purchasePrice, _equipType, _equipCategory);
                            _shoppingList.Add(gameEquip);
                            break;
                        }
                        case "4":
                        {
                            Console.Write("What is the name of the movie or TV show you are purchasing? ");
                            string _purchaseTitle = Console.ReadLine();
                            Console.Write("What type of disc is this movie or TV show (Blu-Ray, DVD, etc)? ");
                            string _purchaseSystem = Console.ReadLine();
                            Console.Write("What is the price of this disc? ");
                            int _purchasePrice = int.Parse(Console.ReadLine());
                            Console.Write("What is the category of this movie or TV show? ");
                            string _discCategory = Console.ReadLine();
                            DiscVideos discVideos = new DiscVideos(_purchaseTitle, _purchaseSystem, _purchasePrice, _discCategory);
                            _shoppingList.Add(discVideos);
                            break;
                        }
                        case "5":
                        {
                            Console.Write("What is the name of the movie or TV show you are purchasing? ");
                            string _purchaseTitle = Console.ReadLine();
                            Console.Write("What type of device are you purchasing this item for (mobile, desktop, TV streaming, etc)? ");
                            string _purchaseSystem = Console.ReadLine();
                            Console.Write("What is the price of this digital movie or TV show? ");
                            int _purchasePrice = int.Parse(Console.ReadLine());
                            Console.Write("What is the name or brand of the device you are purchasing for? ");
                            string _digitalType = Console.ReadLine();
                            Console.Write("What is the category of this movie or show? ");
                            string _digitalCategory = Console.ReadLine();
                            DigitalVideos digitalVideos = new DigitalVideos(_purchaseTitle, _purchaseSystem, _purchasePrice, _digitalType, _digitalCategory);
                            _shoppingList.Add(digitalVideos);
                            break;
                        }
                        case "6":
                        {
                            Console.Write("What genre or company is the player part of? ");
                            string _purchaseTitle = Console.ReadLine();
                            Console.Write("What is the name of the player that you are purchasing? ");
                            string _purchaseSystem = Console.ReadLine();
                            Console.Write("What is the price of this player? (Usually not less than $100) ");
                            int _purchasePrice = int.Parse(Console.ReadLine());
                            Console.Write("How many months would you like to put in for a warranty?" );
                            int _playerWarranty = int.Parse(Console.ReadLine());
                            Console.Write("What is the category of this player? ");
                            string _playerCategory = Console.ReadLine();
                            DiscPlayers discPlayer = new DiscPlayers(_purchaseTitle, _purchaseSystem, _purchasePrice, _playerWarranty, _playerCategory);
                            _shoppingList.Add(discPlayer);
                            break;
                        }
                    }
                    break;
                }
                case "2":
                {
                    Console.WriteLine("Your purchases: ");
                    Console.WriteLine();
                    foreach (VideosGames purchase in _shoppingList)
                    {
                        purchase.DisplayPurchases();
                    }
                    Console.WriteLine($"Total price: ${_totalPrice}");
                    break;
                }
                case "3":
                {
                    IO.SaveFile(_shoppingList, _totalPrice);
                    break;
                }
                case "4":
                {
                    _shoppingList = IO.LoadFile(ref _totalPrice);
                    break;
                }
                case "5":
                {
                    Console.WriteLine("Your purchases: ");
                    Console.WriteLine();
                    foreach (VideosGames purchase in _shoppingList)
                    {
                        purchase.DisplayPurchases();
                        _totalPrice += purchase.GetTotal();
                    }
                    Console.WriteLine($"Total price: ${_totalPrice}");
                    Console.WriteLine();
                    Console.Write("What type of card are you paying with? ");
                    string _cardType = Console.ReadLine();
                    Console.Write("Please enter your credit or debit card number: ");
                    string _cardNumber = Console.ReadLine();
                    // Enter the expiration date as XX/XX
                    Console.Write("Please enter the expiration month and years as XXXX: ");
                    int _expMonth = int.Parse(Console.ReadLine());
                    // Enter the CVV number
                    Console.Write("Please enter the CVV number on your card: ");
                    int _cvvNumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Thank you! Your transaction has been completed! ");
                    break;
                }
                case "6":
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