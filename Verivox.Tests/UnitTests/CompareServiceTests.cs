using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Verivox.Library.Services;
using Verivox.Library.Tariffs;

namespace Verivox.Tests.UnitTests
{
    [TestClass]
    public class CompareServiceTests
    {
        private ICompareService compareService;

        public CompareServiceTests()
        {
            compareService = new CompareService();
        }

        [TestMethod]
        public void OrderShouldBeValid()
        {
            // Arrange
            var models = new List<TariffModel>
            {
                new BasicElectricityTariff { Consumption = 3500 },
                new BasicElectricityTariff { Consumption = 4500 },
                new BasicElectricityTariff { Consumption = 6000 },
                new PackagedTariff { Consumption = 3500 },
                new PackagedTariff { Consumption = 4500 },
                new PackagedTariff { Consumption = 6000 }
            };

            // Act
            var result = compareService.Compare(models);

            // Assert
            Assert.IsTrue(result[0].AnnualCost < result[1].AnnualCost
                && result[1].AnnualCost < result[2].AnnualCost
                && result[2].AnnualCost < result[3].AnnualCost
                && result[3].AnnualCost < result[4].AnnualCost
                && result[4].AnnualCost < result[5].AnnualCost);
        }
    }
}
