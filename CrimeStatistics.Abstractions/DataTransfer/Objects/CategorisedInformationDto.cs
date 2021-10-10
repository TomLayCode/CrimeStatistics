using System.Collections.Generic;

namespace CrimeStatistics.Domain.DataTransfer.Objects
{
    public class CategorisedInformationDto
    {
        public string Category { get; set; }
        public IList<CrimeInformationDto> Crimes { get; set; }
    }
}
