using CrimeStatistics.Application.Querys;
using CrimeStatistics.Domain.DataTransfer.Filters;
using CrimeStatistics.Domain.DataTransfer.Objects;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrimeStatistics.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CrimeInformationController : Controller
    {
        private IMediator _mediator;
        public CrimeInformationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IList<CategorisedInformationDto>> GetCrimeInformationAsync(CrimeFilterDto crimeFilter)
        {
            return await _mediator.Send(new GetCrimeInformation.Query(crimeFilter));
        }
    }
}
