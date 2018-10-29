namespace Verivox.Library.Tariffs
{
    public abstract class TariffModel
    {
        public int Consumption { get; set; }

        public abstract string TariffName { get; }

        public abstract double AnnualCost { get; }
    }
}
