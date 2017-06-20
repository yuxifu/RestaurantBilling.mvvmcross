using System;
using System.Collections.Generic;
using NUnit.Framework;
using MvvmCross.Core.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Core;
using MvvmCross.Test.Core;
using Moq;
using RestaurantBilling.Core.ViewModels;
using RestaurantBilling.Core.Services;
using MvvmCross.Platform;

namespace RestaurantBilling.Tests
{
    [TestFixture]
    public class BillViewModelTests: ViewModelTestsBase
    {
        [SetUp]
        public void Init()
        {
            Setup();            
        }

        [Test]
        public void TestThatWhenSubTotalChangesTipIsRecalculated()
        {
            //Arrange
            var mockTipService = new Mock<IBillCalculator>();
            mockTipService.Setup(t => t.TipAmount(It.IsAny<double>(), It.IsAny<int>()))
                          .Returns(42.0);

            //Act
            var billViewModel = new BillViewModel(mockTipService.Object);
            billViewModel.SubTotal = 12;

            //Assert
            Assert.AreEqual(42.0, billViewModel.Tip);
        }

		[Test]
		public void TestThatWhenGratuityChangesTipIsRecalculated()
		{
			//Arrange
			var mockTipService = new Mock<IBillCalculator>();
			mockTipService.Setup(t => t.TipAmount(It.IsAny<double>(), It.IsAny<int>()))
						  .Returns(37.0);

            //Act
            var billViewModel = new BillViewModel(mockTipService.Object)
            {
                Gratuity = 12
            };

            //Assert
            Assert.AreEqual(37.0, billViewModel.Tip);
		}

		[Test]
		public void TestThatWhenTipIsRecalculatedThenTipNotificationIsSent()
		{
			//Arrange
			var mockTipService = new Mock<IBillCalculator>();
			mockTipService.Setup(t => t.TipAmount(It.IsAny<double>(), It.IsAny<int>()))
						  .Returns(37.0);

            var billViewModel = new BillViewModel(mockTipService.Object);

            var tipChangeCount = 0;
			var gratuityChangeCount = 0;
			var subTotalCount = 0;
            billViewModel.PropertyChanged += (sender, e) =>
            {
                switch(e.PropertyName)
                {
                    case "Tip":
                        tipChangeCount++;
                        break;
					case "SubTotal":
                        subTotalCount++;
						break;
					case "Gratuity":
                        gratuityChangeCount++;
						break;
				}
            };

			//Act
			billViewModel.Gratuity = 12;

			//Assert
            Assert.AreEqual(1, tipChangeCount);
            Assert.AreEqual(0, subTotalCount);
            Assert.AreEqual(1, gratuityChangeCount);
		}

        [Test]
        public void TestThatPayCommandShowsPayViewModelWithCorrectTotal()
        {
            //Arrange
            var mockTipService = new Mock<IBillCalculator>();
            mockTipService.Setup(t => t.TipAmount(It.IsAny<double>(), It.IsAny<int>()))
                          .Returns(19.0);

            var billViewModel = new BillViewModel(mockTipService.Object)
            {
                Gratuity = 12,
                SubTotal = 10
            };

            //act
            billViewModel.PayComamnd.Execute(null);

            //Assert
            Assert.AreEqual(1, MockDispatcher.Requests.Count);
            var request = MockDispatcher.Requests[0];
            Assert.AreEqual(typeof(PayViewModel), request.ViewModelType);
            Assert.AreEqual("29", request.ParameterValues["total"]);
        }
	
    }
}
