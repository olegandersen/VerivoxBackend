namespace Verivox.Library.Tariffs
{
    public class BasicElectricityTariff : TariffModel
    {
        private const int BASE_COST = 5;
        private const double CONSUMPTION_COST = 0.22;

        public override string TariffName => "basic electricity tariff";

        public override double AnnualCost
        {
            get { return (BASE_COST * 12) + (Consumption * CONSUMPTION_COST); }
        }
    }
}
