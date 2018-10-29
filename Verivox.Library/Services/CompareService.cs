using System.Collections.Generic;
using System.Linq;
using Verivox.Library.Tariffs;

namespace Verivox.Library.Services
{
    public class CompareService : ICompareService
    {
        public List<TariffModel> Compare(IEnumerable<TariffModel> tariffs)
        {
            return tariffs.OrderBy(x => x.AnnualCost).ToList();
        }
    }
}
