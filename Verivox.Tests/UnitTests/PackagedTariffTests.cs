using Verivox.Library.Tariffs;
using Xunit;

namespace Verivox.Tests.UnitTests
{
    public class PackagedTariffTests
    {
        [Theory]
        [InlineData(800, 3500)]
        [InlineData(950, 4500)]
        [InlineData(1400, 6000)]
        public void AnnualCostShouldBeValid(int cost, int consumption)
        {
            // Arrange
            var tarrif = new PackagedTariff
            {
                Consumption = consumption
            };

            // Act
            // Assert
            Assert.Equal(cost, tarrif.AnnualCost);
        }
    }
}
