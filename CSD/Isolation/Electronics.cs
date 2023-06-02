namespace CSD.Isolation
{
    public class Electronics : IElectronics
    {
        public void Accelerate()
        {
        }

        public void PushBrakes(int halfBrakingPower)
        {
        }

        public bool IsReady()
        {
            return false;
        }
    }
}