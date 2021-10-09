using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrimeStatistics.Domain.Interfaces.Repositories
{
    public interface ICrimeInformationRepository
    {
        public Task<IList<CrimeInformationDto>> GetCrimeDataAsync(CrimeFilterDto crimeFilter);
    }
}
