using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using CrimeStatistics.Domain.Interfaces.Repositories;
using CrimeStatistics.Persistance.Entities;
using CrimeStatistics.Persistance.MappingExtensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrimeStatistics.Persistance.RequestRepositories
{
    public class CrimeInformationRepository : ICrimeInformationRepository
    {
        private readonly ApiRequestService _apiRequestService;

        public CrimeInformationRepository(ApiRequestService apiRequestService)
        {
            _apiRequestService = apiRequestService;
        }

        public async Task<IList<CrimeInformationDto>> GetCrimeDataAsync(CrimeFilterDto crimeFilter)
        {
            var url = $"crimes-street/all-crime?lat={crimeFilter.Latitude}&lng={crimeFilter.Longitude}";

            if (crimeFilter.Month.HasValue)
            {
                url = url + $"&date ={ crimeFilter.Month?.ToString("yyyy-MM")}";
            }

            var request = await _apiRequestService.ExecuteApiRequest<IList<CrimeData>>(url);
            
            return request.ToCrimeInformationDto(); ;
        }
    }
}
