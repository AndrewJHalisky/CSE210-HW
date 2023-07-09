using System;

public class Games : VideosGames
{
    private int _gamePrice;

    public Games(string purchaseTitle, string purchaseSystem, string purchaseDescription, int gamePrice) : base(purchaseTitle, purchaseSystem, purchaseDescription)
    {
        _gamePrice = gamePrice;
    }
}