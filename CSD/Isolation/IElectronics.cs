namespace CSD.Isolation
{
    public interface IElectronics
    {
        void Accelerate();
        bool IsReady();
        void PushBrakes(int halfBrakingPower);
    }
}