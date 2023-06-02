using System.Threading;

namespace CSD.Isolation
{
    public class StatusPanel : IStatusPanel
    {

        public int Speed { get; }

        public bool ThereIsEnoughFuel()
        {
            return false;
        }

        public bool EngineIsRunning()
        {
            // Check engine takes a long time to run
            Thread.Sleep(1000 * 100);
            return false;
        }

        public bool IsReady()
        {
            return false;
        }
    }
}