using System;

public class DigitalVideos : VideosGames
{
    public string _mobileType;
    public int _digitalPrice;

    public DigitalVideos(string purchaseTitle, string purchaseSystem, string purchaseDescription, string mobileType, int digitalPrice) : base(purchaseTitle, purchaseSystem, purchaseDescription)
    {
        mobileType = _mobileType;
        digitalPrice = _digitalPrice;
    }
}