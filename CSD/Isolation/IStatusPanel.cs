namespace CSD.Isolation
{
    public interface IStatusPanel
    {
        int Speed { get; }

        bool EngineIsRunning();
        bool IsReady();
        bool ThereIsEnoughFuel();
    }
}