using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using CrimeStatistics.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrimeStatistics.Infrastructure.Services
{
    public class CrimeInformationService : ICrimeInformationService
    {
        public Task<IList<CrimeInformationDto>> GetCrimeInformation(CrimeFilterDto crimeFilter)
        {
            throw new System.NotImplementedException();
        }
    }
}
