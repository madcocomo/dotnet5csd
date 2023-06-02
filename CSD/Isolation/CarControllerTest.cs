using NUnit.Framework;
using Moq;

namespace CSD.Isolation
{
    public class CarControllerTest
    {
        [Test]
        public void TestItCanGetReadyTheCar()
        {
            var carController = new CarController();

            var engine = Mock.Of<IEngine>( o => o.IsReady() == true );
            var gearbox = Mock.Of<IGearbox>( o => o.IsReady() == true );
            var electronics = Mock.Of<IElectronics>( o => o.IsReady() == true );
            var statusPanel = Mock.Of<IStatusPanel>( o => o.IsReady() == true );

            var result = carController.GetReadyToGo(engine, gearbox, electronics, statusPanel);

            Assert.IsTrue(result);
        }

        [Test]
        public void TestItCanAccelerate()
        {
            var carController = new CarController();
            var electronicsMock = new Mock<IElectronics>();
            var statusPanel = Mock.Of<IStatusPanel>(
                s => s.EngineIsRunning() == true && 
                s.ThereIsEnoughFuel() == true
                );

            carController.GoForward(electronicsMock.Object, statusPanel);

            electronicsMock.Verify(e => e.Accelerate());
        }

        [Test]
        public void TestItCanStop()
        {
            var carController = new CarController();
            var halfBrakingPower = 50;
            var electronics = Mock.Of<IElectronics>();
            var statusPanelMock = new Mock<IStatusPanel>();
            statusPanelMock.SetupSequence(s => s.Speed).Returns(10).Returns(0);

            carController.Stop(halfBrakingPower, electronics, statusPanelMock.Object);

            Mock.Get(electronics).Verify(e => e.PushBrakes(50), Times.Exactly(2));

        }
    }

}