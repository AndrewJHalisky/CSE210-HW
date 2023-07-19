using System;

public class GameEquipment : VideosGames
{
    private string _equipType;
    private string _equipCategory;
    public int _type = 3;
    public GameEquipment(string purchaseTitle, string purchaseSystem, int purchasePrice, string equipType, string equipCategory) : base(purchaseTitle, purchaseSystem, purchasePrice)
    {
        equipType = _equipType;
        equipCategory = _equipCategory;
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
        return $"{_type}, {_purchaseTitle}, {_purchaseSystem}, {_purchasePrice}, {_equipType}, {_equipCategory}";
    }

}