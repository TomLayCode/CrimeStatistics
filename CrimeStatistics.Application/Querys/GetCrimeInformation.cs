using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using CrimeStatistics.Domain.Interfaces.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CrimeStatistics.Application.Querys
{
    public class GetCrimeInformation : IRequest<List<CrimeInformationDto>>
    {
        public CrimeFilterDto CrimeFilter { get;}

        public GetCrimeInformation(CrimeFilterDto crimeFilter)
        {
            CrimeFilter = crimeFilter;
        }
    }
    public class GeyCrimeInformationHandler : IRequestHandler<GetCrimeInformation, IList<CrimeInformationDto>>
    {
        private readonly ICrimeInformationService _crimeInformation;
        public GeyCrimeInformationHandler(ICrimeInformationService crimeInformation)
        {
            _crimeInformation = crimeInformation;
        }
        public async Task<IList<CrimeInformationDto>> Handle(GetCrimeInformation request, CancellationToken cancellationToken)
        {
            return await _crimeInformation.GetCrimeInformation(request.CrimeFilter);
        }
    }
}
