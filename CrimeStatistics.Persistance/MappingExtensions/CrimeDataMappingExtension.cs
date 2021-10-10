using CrimeStatistics.Domain.DataTransfer.Objects;
using CrimeStatistics.Persistance.Entities;
using System.Collections.Generic;
using System.Linq;

namespace CrimeStatistics.Persistance.MappingExtensions
{
    public static class CrimeDataMappingExtension
    {
        public static IList<CrimeInformationDto> ToCrimeInformationDto(this IList<CrimeData> crimeData)
        {
            return crimeData.Select(cd => new CrimeInformationDto
            {
                Id = cd.Id,
                Category = cd.Category,
                Context = cd.Context,
                LocationType = cd.LocationType,
                Latitude = cd.Location.Latitude,
                Longitude = cd.Location.Longitude,
                StreetName = cd.Location.Street?.name,
                Month = cd.Month,
                OutcomeCategory = cd.OutcomeStatus?.Category,
                OutComeDate = cd.OutcomeStatus?.Date
            }).ToList();
        }
    }
}
