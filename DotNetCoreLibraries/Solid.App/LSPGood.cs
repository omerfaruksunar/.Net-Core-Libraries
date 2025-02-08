namespace Solid.App.LSPGood;

public interface IPlayGame
{
    void PlayGame();
}

public abstract class BasePC
{
    public void EditVideo()
    {
        Console.WriteLine("Video editlendi");
    }
}



public class Monster : BasePC,IPlayGame
{
    public void PlayGame()
    {
        Console.WriteLine("Oyun Oynandı.");
    }
}

public class MacBook : BasePC
{
    
}

