namespace Verivox.Library.Tariffs
{
    public class PackagedTariff : TariffModel
    {
        private const int TOP_KWH_PER_YEAR = 4000;
        private const int DEFAULT_CONSUMPTION = 800;
        private const double CONSUMPTION_COST = 0.30;

        public override string TariffName => "Packaged tariff";

        public override double AnnualCost
        {
            get
            {
                return Consumption > TOP_KWH_PER_YEAR
                    ? (Consumption - TOP_KWH_PER_YEAR) * CONSUMPTION_COST + DEFAULT_CONSUMPTION
                    : DEFAULT_CONSUMPTION;
            }
        }
    }
}
