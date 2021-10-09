using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrimeStatistics.Domain.Interfaces.Services
{
    public interface ICrimeInformationService
    {
        public Task<IList<CrimeInformationDto>> GetCrimeInformation(CrimeFilterDto crimeFilter);
    }
}
