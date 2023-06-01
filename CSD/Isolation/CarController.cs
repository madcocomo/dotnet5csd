namespace CSD.Isolation
{
    public class CarController
    {
        public bool GetReadyToGo(Engine engine, Gearbox gearbox, Electronics electronics, StatusPanel statusPanel)
        {
            return engine.IsReady() && gearbox.IsReady() && electronics.IsReady() && statusPanel.IsReady();
        }

        public void GoForward(Electronics electronics, StatusPanel statusPanel)
        {
            if (statusPanel.EngineIsRunning() && statusPanel.ThereIsEnoughFuel())
                electronics.Accelerate();
        }

        public void Stop(int halfBrakingPower, Electronics electronics, StatusPanel statusPanel)
        {
            electronics.PushBrakes(halfBrakingPower);
            if (statusPanel.Speed > 0)
            {
                this.Stop(halfBrakingPower, electronics, statusPanel);
            }
        }
    }
}