using System;

public class GameEquipment : VideosGames
{
    public string _equipType;
    public int _equipPrice;
    public GameEquipment(string purchaseTitle, string purchaseSystem, string purchaseDescription, string equipType, int equipPrice) : base(purchaseTitle, purchaseSystem, purchaseDescription)
    {
        equipType = _equipType;
        equipPrice = _equipPrice;
    }

}