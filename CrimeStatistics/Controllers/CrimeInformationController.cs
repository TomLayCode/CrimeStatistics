using CrimeStatistics.Application.Querys;
using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrimeStatistics.Controllers
{
    //Acceptance Criteria
    //• For any UK latitude/longitude and a month in the last year, a summary of crimes is returned.
    //• The count of crimes are shown, grouped by category.
    //Technical Requirements
    //• The solution should make use of .NET, but the type of application is not limited.
    //• You may use whatever libraries / packages you wish.
    //• Your solution must include tests.

    public class CrimeInformationController : Controller
    {
        private readonly IMediator _mediator;
        public CrimeInformationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IList<CrimeInformationDto>> GetCrimeInformationAsync(CrimeFilterDto crimeFilter)
        {
            return await _mediator.Send(new GetCrimeInformation(crimeFilter));
            
        }
    }
}
