using NUnit.Framework;

namespace Katas.Test
{
    public class Kata001Test
    {
        [Test]
        public void ShouldWork()
        {
            Kata001 kata001 = new Kata001();
            Assert.AreEqual("Even", kata001.EvenOrOdd(2));
            Assert.AreEqual("Odd", kata001.EvenOrOdd(1));
            Assert.AreEqual("Even", kata001.EvenOrOdd(0));
            Assert.AreEqual("Odd", kata001.EvenOrOdd(7));
            Assert.AreEqual("Odd", kata001.EvenOrOdd(-1));
        }
    }
}
