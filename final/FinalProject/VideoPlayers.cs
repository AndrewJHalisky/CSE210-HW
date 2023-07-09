using System;

public class VideoPlayers : VideosGames
{
    private string _playerType;
    private int _playerPrice;

    public VideoPlayers(string purchaseTitle, string purchaseSystem, string purchaseDescription, string playerType, int playerPrice) : base(purchaseTitle, purchaseSystem, purchaseDescription)
    {
        playerType = _playerType;
        playerPrice = _playerPrice;
    }
    
}