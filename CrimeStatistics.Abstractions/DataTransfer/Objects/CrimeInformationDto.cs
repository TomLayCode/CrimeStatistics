using System;

namespace CrimeStatistics.Domain.DataTransfer.Objects
{
    public class CrimeInformationDto
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string LocationType { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string StreetName { get; set; }
        public string Context { get; set; }
        public DateTime? Month { get; set; }
        public string OutcomeCategory { get; set; }
        public DateTime? OutComeDate { get; set; }
    }
}
