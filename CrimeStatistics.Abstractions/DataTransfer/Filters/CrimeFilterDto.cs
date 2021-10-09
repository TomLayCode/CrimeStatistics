using System;

namespace CrimeStatistics.Domain.DataTransfer.Filters
{
    public class CrimeFilterDto
    {
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public DateTime? Month { get; set; }
    }
}
