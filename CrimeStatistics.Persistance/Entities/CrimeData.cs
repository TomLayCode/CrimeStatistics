using System;

namespace CrimeStatistics.Persistance.Entities
{
    public class CrimeData
    {
        public int Id { get; set; }
        public string PersistentId { get; set; }
        public string Category { get; set; }
        public string LocationType { get; set; }
        public LocationData Location { get; set; }
        public string Context { get; set; }
        public OutcomeStatusData OutcomeStatus { get; set; }
        public string LocationSubType { get; set; }
        public DateTime Month { get; set; }
    }
}
