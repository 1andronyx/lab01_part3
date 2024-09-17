using Lab2t;
using System.Drawing;

namespace Lab2t.Tests
{
    [TestFixture]
    public class PointTests
    {
        [Test]
        public void Point_StoresCoordinatesCorrectly()
        {

            int x = 5;
            int y = 10;


            Point point = new Point(x, y);


            //Assert.AreEqual(x, point.X, "Координата X была сохранена неправильно.");
            Assert.That(y == point.Y, "Координата Y была сохранена неправильно.");
        }
    }

    
}
