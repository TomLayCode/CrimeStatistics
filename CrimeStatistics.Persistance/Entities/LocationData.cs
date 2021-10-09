namespace CrimeStatistics.Persistance.Entities
{
    public class LocationData
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public StreetData Street { get; set; }
    }
}
