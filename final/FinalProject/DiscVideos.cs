using System;

public class DiscVideos : VideosGames
{
    private string _discCategory;
    public int _type = 4;

    public DiscVideos(string purchaseTitle, string purchaseSystem, int purchasePrice, string discCategory) : base(purchaseTitle, purchaseSystem, purchasePrice)
    {
        _discCategory = discCategory;
    }

    public override int GetTotal()
    {
        return _purchasePrice;
    }

    public override void DisplayPurchases()
    {
        Console.WriteLine($"{_purchaseTitle}, {_purchaseSystem} - ${_purchasePrice}");
    }

    public override string SavePurchase()
    {
        return $"{_type}, {_purchaseTitle}, {_purchaseSystem}, {_purchasePrice}, {_discCategory}";
    }

}