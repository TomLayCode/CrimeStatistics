using AutoFixture;
using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using CrimeStatistics.Persistance.Entities;
using System;
using System.Collections.Generic;

namespace CrimeStatistics.Tests.Helpers
{
    public class CrimeHelpers
    {
        public CrimeFilterDto GenerateCrimeFilterDto()
        {
            var fixture = new Fixture();

            return new CrimeFilterDto
            {
                Latitude = fixture.Create<decimal>(),
                Longitude = fixture.Create<decimal>(),
                Month = fixture.Create<DateTime?>()
            };
        }

        public CrimeData GenerateCrimeData()
        {
            var fixture = new Fixture();

            return new CrimeData()
            {
                Id = fixture.Create<int>(),
                Category = fixture.Create<string>(),
                Context = fixture.Create<string>(),
                LocationSubType = fixture.Create<string>(),
                LocationType = fixture.Create<string>(),
                Location = GenerateLocationData(),
                OutcomeStatus = GenerateOutcomeStatusData(),
                Month = fixture.Create<DateTime>(),
                PersistentId = fixture.Create<string>()
            };
        }

        private LocationData GenerateLocationData()
        {
            var fixture = new Fixture();

            return new LocationData
            {
                Latitude = fixture.Create<decimal>(),
                Longitude = fixture.Create<decimal>(),
                Street = GenerateStreetData(),
            };
        }

        private StreetData GenerateStreetData()
        {
            var fixture = new Fixture();

            return new StreetData
            {
                Id = fixture.Create<int>(),
                name = fixture.Create<string>()
            };
        }

        private OutcomeStatusData GenerateOutcomeStatusData()
        {
            var fixture = new Fixture();

            return new OutcomeStatusData
            { 
                Category = fixture.Create<string>(),
                Date = fixture.Create<DateTime?>()
            };
        }

        public IList<CrimeData> GenerateCrimeDataList(int listLength)
        {
            var fixture = new Fixture();
            var crimeDataList = new List<CrimeData>();

            for (var i = 0; i < listLength; i++)
            {
                crimeDataList.Add(GenerateCrimeData());
            }

            return crimeDataList;
        }

        public CrimeInformationDto GenerateCrimeInformationDto()
        {
            var fixture = new Fixture();

            return new CrimeInformationDto
            {
                Id = fixture.Create<int>(),
                Category = fixture.Create<string>(),
                Context = fixture.Create<string>(),
                Latitude = fixture.Create<decimal>(),
                Longitude = fixture.Create<decimal>(),
                StreetName = fixture.Create<string>(),
                LocationType = fixture.Create<string>(),
                OutcomeCategory = fixture.Create<string>(),
                OutComeDate = fixture.Create<DateTime?>(),
                Month = fixture.Create<DateTime?>()
            };
        }

        public IList<CrimeInformationDto> GenerateCrimeInformationDtoList(int listLength)
        {
            var fixture = new Fixture();
            var crimeInformation = new List<CrimeInformationDto>();

            for (var i = 0; i < listLength; i++)
            {
                crimeInformation.Add(GenerateCrimeInformationDto());
            }

            return crimeInformation;
        }

        public CategorisedInformationDto GenerateCategorisedInformationDto()
        {
            var fixture = new Fixture();

            return new CategorisedInformationDto
            {
                Category = fixture.Create<string>(),
                Crimes = GenerateCrimeInformationDtoList(5)
            };
        }

        public IList<CategorisedInformationDto> GenerateCategorisedInformationDtoList(int listLength)
        {
            var fixture = new Fixture();
            var categorisedList = new List<CategorisedInformationDto>();

            for (var i = 0; i < listLength; i++)
            {
                categorisedList.Add(GenerateCategorisedInformationDto());
            }

            return categorisedList;
        }
    }
}
