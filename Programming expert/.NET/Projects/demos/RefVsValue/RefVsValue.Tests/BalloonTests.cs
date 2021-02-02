using NUnit.Framework;
using RefVsValue;

namespace Tests
{
    public class BalloonTests
    {
        [Test]
        public void TwoBalloonReferencesSameObject()
        {
            var redBalloon = new Balloon()
            {
                ColorHex = "#FF0000",
                Size = 15.0
            };

            var anotherBalloon = redBalloon;

            Assert.AreSame(anotherBalloon, redBalloon);
        }
    }
}