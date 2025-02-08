namespace Solid.App.LSPBad;

public abstract class BasePC
{
    public void EditVideo()
    {
        Console.WriteLine("Video editlendi");
    }

    public abstract void PlayGame();
}



public class Monster : BasePC
{
    public override void PlayGame()
    {
        Console.WriteLine("Oyun Oynandı.");
    }
}

public class MacBook : BasePC
{
    public override void PlayGame()
    {
        throw new NotImplementedException();
    }
}

