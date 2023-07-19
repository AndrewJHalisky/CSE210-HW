using System;

public class Games : VideosGames
{
    private string _gameCategory;

    public int _type = 1;

    public Games(string purchaseTitle, string purchaseSystem, int purchasePrice, string gameCategory) : base(purchaseTitle, purchaseSystem, purchasePrice)
    {
        _gameCategory = gameCategory;
    }

    public override void DisplayPurchases()
    {
        Console.WriteLine($"{_purchaseTitle}, {_purchaseSystem} - ${_purchasePrice}");
    }

    public override int GetTotal()
    {
        return _purchasePrice;
    }

    public override string SavePurchase()
    {
        return $"{_type}, {_purchaseTitle}, {_purchaseSystem}, {_purchasePrice}, {_gameCategory}";
    }
}