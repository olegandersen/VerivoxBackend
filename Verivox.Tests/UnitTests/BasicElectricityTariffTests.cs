using Verivox.Library.Tariffs;
using Xunit;

namespace Verivox.Tests.UnitTests
{
    public class BasicElectricityTariffTests
    {
        [Theory]
        [InlineData(830, 3500)]
        [InlineData(1050, 4500)]
        [InlineData(1380, 6000)]
        public void AnnualCostShouldBeValid(int cost, int consumption)
        {
            // Arrange
            var tarrif = new BasicElectricityTariff
            {
                Consumption = consumption
            };

            // Act
            // Assert
            Assert.Equal(cost, tarrif.AnnualCost);
        }
    }
}
