using System;

public class DigitalVideos : VideosGames
{
    private string _digitalType;
    private string _digitalCategory;
    public int _type = 5;

    public DigitalVideos(string purchaseTitle, string purchaseSystem, int purchasePrice, string digitalType, string digitalCategory) : base(purchaseTitle, purchaseSystem, purchasePrice)
    {
        digitalType = _digitalType;
        digitalCategory = _digitalCategory;
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
        return $"{_type}, {_purchaseTitle}, {_purchaseSystem}, {_purchasePrice}, {_digitalCategory}, {_digitalType}";
    }
}