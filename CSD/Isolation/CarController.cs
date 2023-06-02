namespace CSD.Isolation
{
    public class CarController
    {
        public bool GetReadyToGo(IEngine engine, IGearbox gearbox, IElectronics electronics, IStatusPanel statusPanel)
        {
            return engine.IsReady() && gearbox.IsReady() && electronics.IsReady() && statusPanel.IsReady();
        }

        public void GoForward(IElectronics electronics, IStatusPanel statusPanel)
        {
            if (statusPanel.EngineIsRunning() && statusPanel.ThereIsEnoughFuel())
                electronics.Accelerate();
        }

        public void Stop(int halfBrakingPower, IElectronics electronics, IStatusPanel statusPanel)
        {
            electronics.PushBrakes(halfBrakingPower);
            if (statusPanel.Speed > 0)
            {
                this.Stop(halfBrakingPower, electronics, statusPanel);
            }
        }
    }
}