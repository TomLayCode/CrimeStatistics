using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using CrimeStatistics.Domain.Interfaces.Repositories;
using CrimeStatistics.Infrastructure.Services;
using CrimeStatistics.Tests.Helpers;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace CrimeStatistics.Tests.CrimeInformationTests
{
    public class CrimeServiceTests
    {
        private readonly Mock<ICrimeInformationRepository> _mockCrimeInformationRepository;
        private readonly CrimeHelpers _helpers;

        public CrimeServiceTests()
        {
            _mockCrimeInformationRepository = new Mock<ICrimeInformationRepository>();
            _helpers = new CrimeHelpers();
        }

        [Fact]
        public async Task GetCrimeInformation_WithValidFilterAndDate_ReturnsCategorisedCrimesAsync()
        {
            //Arrange

            var filter = _helpers.GenerateCrimeFilterDto();
            var crimeInformationList = _helpers.GenerateCrimeInformationDtoList(5);

            SetupCrimeRepository(filter, crimeInformationList);

            var crimeService = this.CreateCrimeInformationService();

            //Act
            var results = await crimeService.GetCrimeInformation(filter);

            //Assert

        }

        [Fact]
        public async Task GetCrimeInformation_WithValidFilterAndNoDate_ReturnsCategorisedCrimesAsync()
        {
            //Arrange

            var filter = _helpers.GenerateCrimeFilterDto();
            filter.Month = null;

            var crimeInformationList = _helpers.GenerateCrimeInformationDtoList(5);

            SetupCrimeRepository(filter, crimeInformationList);

            var crimeService = this.CreateCrimeInformationService();

            //Act
            var results = await crimeService.GetCrimeInformation(filter);

            //Assert

        }

        [Fact]
        public async Task GetCrimeInformation_WithInvalidFilter_ThrowsValidationErrorAsync()
        {
            //Arrange

            var filter = new CrimeFilterDto();
            var crimeInformationList = _helpers.GenerateCrimeInformationDtoList(5);

            SetupCrimeRepository(filter, crimeInformationList);

            var crimeService = this.CreateCrimeInformationService();

            //Act
            var results = await crimeService.GetCrimeInformation(filter);

            //Assert

        }

        private void SetupCrimeRepository(CrimeFilterDto crimeFilter, IList<CrimeInformationDto> crimeInformationList)
        {
            _mockCrimeInformationRepository
                .Setup(cir => cir.GetCrimeDataAsync(crimeFilter))
                .Returns( Task.FromResult(crimeInformationList));
        }

        private CrimeInformationService CreateCrimeInformationService()
        {
            return new CrimeInformationService(
                _mockCrimeInformationRepository.Object
                );
        }
    }
}
