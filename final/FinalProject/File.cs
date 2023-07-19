using System;

public class File
{
    public string _listName;

    public void SaveFile(List<VideosGames> saveList, int totalPrice)
    {
        Console.Write("Please give this list of purchase a name: ");
        _listName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_listName))
        {
            outputFile.WriteLine(totalPrice);
            foreach (VideosGames p in saveList)
            {
                outputFile.WriteLine(p.SavePurchase());
            }
            Console.WriteLine("List successfully saved! ");
        }
    }

    public List<VideosGames> LoadFile(ref int totalPrice)
    {
        Console.Write("What is the name of this list? ");
        _listName = Console.ReadLine();
        List<VideosGames> saveList = new List<VideosGames>();
        int price;
        string title;
        string system;
        string gameCatg;
        string sysCatg;
        string equipCatg;
        string discCatg;
        string playCatg;
        string digitCatg;
        int sysWart;
        string equipType;
        int playWart;
        string digitType;
        string[] lines = System.IO.File.ReadAllLines(_listName);
        if (lines != null)
        {
            totalPrice = int.Parse(lines[0]);

            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                int type = int.Parse(parts[0]);
                if (type == 1)
                {
                    title = parts[1];
                    price = int.Parse(parts[3]);
                    system = parts[2];
                    gameCatg = parts[4];
                    Games videoGame = new Games(title, system, price, gameCatg);
                    saveList.Add(videoGame);
                }
                else if (type == 2)
                {
                    title = parts[1];
                    price = int.Parse(parts[3]);
                    system = parts[2];
                    sysWart = int.Parse(parts[4]);
                    sysCatg = parts[5];
                    GameSystems gameSystems = new GameSystems(title, system, price, sysWart, sysCatg);
                    saveList.Add(gameSystems);
                }
                else if (type == 3)
                {
                    title = parts[1];
                    price = int.Parse(parts[3]);
                    system = parts[2];
                    equipType = parts[4];
                    equipCatg = parts[5];
                    GameEquipment gameEquipment = new GameEquipment(title, system, price, equipType, equipCatg);
                    saveList.Add(gameEquipment);
                }
                else if (type == 4)
                {
                    title = parts[1];
                    price = int.Parse(parts[3]);
                    system = parts[2];
                    discCatg = parts[4];
                    DiscVideos discVideos = new DiscVideos(title, system, price, discCatg);
                    saveList.Add(discVideos);
                }
                else if (type == 5)
                {
                    title = parts[1];
                    price = int.Parse(parts[3]);
                    system = parts[2];
                    digitCatg = parts[4];
                    digitType = parts[5];
                    DigitalVideos digitalVideos = new DigitalVideos(title, system, price, digitCatg, digitType);
                    saveList.Add(digitalVideos);
                }
                else if (type == 6)
                {
                    title = parts[1];
                    price = int.Parse(parts[3]);
                    system = parts[2];
                    playWart = int.Parse(parts[4]);
                    playCatg = parts[5];
                    DiscPlayers discPlayers = new DiscPlayers(title, system, price, playWart, playCatg);
                    saveList.Add(discPlayers);
                }
            }
            Console.WriteLine("List successfully loaded! ");
            return saveList;
        }
        else
        {
            return new List<VideosGames>();
        }

    }
}