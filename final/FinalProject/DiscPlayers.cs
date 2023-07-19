using System;

public class DiscPlayers : VideosGames
{
    private int _playerWarranty;
    private string _playerCategory;
    public int _type = 6;

    public DiscPlayers(string purchaseTitle, string purchaseSystem, int purchasePrice, int playerWarranty, string playerCategory) : base(purchaseTitle, purchaseSystem, purchasePrice)
    {
        playerWarranty = _playerWarranty;
        playerCategory = _playerCategory;
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
        return $"{_type}, {_purchaseTitle}, {_purchaseSystem}, {_purchasePrice}, {_playerWarranty}, {_playerCategory}";
    }
    
}