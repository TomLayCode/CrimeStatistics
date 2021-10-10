using Newtonsoft.Json;
using System;

namespace CrimeStatistics.Persistance.Entities
{
    public class CrimeData
    {
        public int Id { get; set; }

        [JsonProperty("persistent_id")]
        public string PersistentId { get; set; }

        public string Category { get; set; }

        [JsonProperty("location_type")]
        public string LocationType { get; set; }

        public LocationData Location { get; set; }

        public string Context { get; set; }

        [JsonProperty("outcome_status")]
        public OutcomeStatusData OutcomeStatus { get; set; }

        [JsonProperty("location_subtype")]
        public string LocationSubType { get; set; }

        public DateTime Month { get; set; }

    }
}
