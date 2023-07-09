using System;

public class GameSystems : VideosGames 
{
    private string _systemType;
    private int _systemPrice;

    public GameSystems(string purchaseTitle, string purchaseSystem, string purchaseDescription, string systemType, int systemPrice) : base(purchaseTitle, purchaseSystem, purchaseDescription)
    {
        systemType = _systemType;
        systemPrice = _systemPrice;
    }

}