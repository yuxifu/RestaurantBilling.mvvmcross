using NUnit.Framework;
using RestaurantBilling.Core.Services;

namespace RestaurantBilling.Tests
{
	[TestFixture]
	public class BillCalculatorTests
    {
        [Test]
        public void TestThatZeroGratuityReturnsZeroTip()
        {
            //Arrange
            var tip = new BillCalculator();

            //Act
            var result = tip.TipAmount(42.35, 0);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestCase(10.25, 10)]
		[TestCase(10.25, 15)]
		[TestCase(10.25, 20)]
		public void TestThatGratuityReturnsCorrespondingTip(double subTotal, int gratuity )
		{
			//Arrange
			var tip = new BillCalculator();

			//Act
			var result = tip.TipAmount(subTotal, gratuity);

            //Assert
            Assert.AreEqual(subTotal * gratuity / 100.0, result);
		}

    }
}
