using NUnit.Framework;
namespace CSD.Isolation
{
    public class CarControllerTest
    {
        [Test]
        public void TestItCanGetReadyTheCar()
        {
            var carController = new CarController();

            var engine = new Engine();
            var gearbox = new Gearbox();
            var electronics = new Electronics();
            var statusPanel = new StatusPanel();

            var result = carController.GetReadyToGo(engine, gearbox, electronics, statusPanel);

            Assert.IsTrue(result);
        }

        [Test, Ignore("Ignored")]
        public void TestItCanAccelerate()
        {
            var carController = new CarController();

            carController.GoForward(new Electronics(), new StatusPanel());
        }

        [Test]
        public void TestItCanStop()
        {
            var carController = new CarController();
            var halfBrakingPower = 50;
            carController.Stop(halfBrakingPower, new Electronics(), new StatusPanel());
        }
    }

}