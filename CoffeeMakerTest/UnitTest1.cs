using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeMakerDemo;
using static CoffeeMakerDemo.StarBucks;
using Moq;

namespace CoffeeMakerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Coffee_should_return_message()
        {
            StarBucksStore store = new StarBucksStore(new FakeStarBuckStore());
            string result = store.OrderCoffee(2, 2);
            Assert.AreEqual("Your order is received", result);
        }

        [TestMethod]
        public void Order_Coffee_should_return_message()
        {
            StarBucksStore store = new StarBucksStore(new StubStarBucks());
            string result = store.OrderCoffee(2, 2);
            Assert.AreEqual("Your order is received", result);
        }

        [TestMethod]
        public void OrderCoffee_Should_Return_Message_Using_Mock()
        {
            var service = new Mock<IMakeACoffee>();
            service.Setup(x => x.CheckingIngredientsAvailability()).Returns(true);
            service.Setup(x => x.CoffeeMaking(It.IsAny<int>(), It.IsAny<int>())).Returns("Your order is received");
            var store = new StarBucksStore(service.Object);
            var result = store.OrderCoffee(2, 4);
            Assert.AreEqual("Your order is received", result);

        }

    }
}
