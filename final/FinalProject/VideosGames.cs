using System;

public abstract class VideosGames
{
    public string _purchaseTitle;
    public string _purchaseSystem;
    public int _purchasePrice;
    public int _purchaseRemove;

    public VideosGames(string purchaseTitle, string purchaseSystem, int purchasePrice)
    {
        _purchaseTitle = purchaseTitle;
        _purchaseSystem = purchaseSystem;
        _purchasePrice = purchasePrice;
    }

    public abstract int GetTotal();

    public abstract void DisplayPurchases();

    public abstract string SavePurchase();

}
