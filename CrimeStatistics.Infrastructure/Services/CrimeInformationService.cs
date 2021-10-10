using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using CrimeStatistics.Domain.Interfaces.Repositories;
using CrimeStatistics.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrimeStatistics.Infrastructure.Services
{
    public class CrimeInformationService : ICrimeInformationService
    {
        private readonly ICrimeInformationRepository _crimeInformationRepository;

        public CrimeInformationService(ICrimeInformationRepository crimeInformationRepository)
        {
            _crimeInformationRepository = crimeInformationRepository;
        }

        public async Task<IList<CategorisedInformationDto>> GetCrimeInformation(CrimeFilterDto crimeFilter)
        {
            return categoriseCrimes(await _crimeInformationRepository.GetCrimeDataAsync(crimeFilter));
        }

        private IList<CategorisedInformationDto> categoriseCrimes(IList<CrimeInformationDto> crimes)
        {
            var catagorisedInformation = new List<CategorisedInformationDto>();

            var keys =crimes
                .Select(ag => ag.Category)
                .Distinct()
                .ToList();

            foreach (var key in keys)
            {
                catagorisedInformation.Add(new CategorisedInformationDto
                {
                    Category = key,
                    Crimes = crimes
                        .Where(r => r.Category == key)
                        .ToList()
                });
            }

            return catagorisedInformation;
        }
    }
}
