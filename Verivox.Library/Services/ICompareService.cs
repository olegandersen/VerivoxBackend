using System.Collections.Generic;
using Verivox.Library.Tariffs;

namespace Verivox.Library.Services
{
    public interface ICompareService
    {
        List<TariffModel> Compare(IEnumerable<TariffModel> tariffs);
    }
}
