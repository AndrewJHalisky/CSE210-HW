using System;

public class GameSystems : VideosGames 
{
    private int _systemWarranty;
    private string _systemCategory;
    public int _type = 2;

    public GameSystems(string purchaseTitle, string purchaseSystem, int purchasePrice, int systemWarranty, string systemCategory) : base(purchaseTitle, purchaseSystem, purchasePrice)
    {
        systemWarranty = _systemWarranty;
        systemCategory = _systemCategory;
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
        return $"{_type}, {_purchaseTitle}, {_purchaseSystem}, {_purchasePrice}, {_systemWarranty}, {_systemCategory}";
    }

}