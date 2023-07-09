using System;

public class DiscVideos : VideosGames
{
    public string _discType;
    public int _discPrice;

    public DiscVideos(string purchaseTitle, string purchaseSystem, string purchaseDescription, string discType, int discPrice) : base(purchaseTitle, purchaseSystem, purchaseDescription)
    {
        _discType = discType;
        _discPrice = discPrice;
    }
}