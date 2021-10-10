using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using CrimeStatistics.Domain.Interfaces.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CrimeStatistics.Application.Querys
{
    public class GetCrimeInformation
    {
        public class Query : IRequest<IList<CategorisedInformationDto>>
        {
            public CrimeFilterDto CrimeFilter { get; }

            public Query(CrimeFilterDto crimeFilter)
            {
                CrimeFilter = crimeFilter;
            }
        }

        public class Handler : IRequestHandler<Query, IList<CategorisedInformationDto>>
        {
            private readonly ICrimeInformationService _crimeInformation;
            public Handler(ICrimeInformationService crimeInformation)
            {
                _crimeInformation = crimeInformation;
            }
            public async Task<IList<CategorisedInformationDto>> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _crimeInformation.GetCrimeInformation(request.CrimeFilter);
            }
        }
    }
    
}
