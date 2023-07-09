using System;

public abstract class VideosGames
{
    public string _purchaseTitle;
    public string _purchaseSystem;
    public string _purchaseDescription;
    public int _purchaseRemove;

    public VideosGames(string purchaseTitle, string purchaseSystem, string purchaseDescription)
    {
        _purchaseTitle = purchaseTitle;
        _purchaseSystem = purchaseSystem;
        _purchaseDescription = purchaseDescription;
    }

}
