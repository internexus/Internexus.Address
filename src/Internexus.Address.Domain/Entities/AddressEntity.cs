namespace Internexus.Address.Domain.Entities
{
    public class AddressEntity
    {
        public int Id { get; set; }
        public int Zipcode { get; set; }
        public string? Street { get; set; } = String.Empty;
        public string? Number { get; set; } = String.Empty;
        public string? Complement { get; set; } = String.Empty;
        public string? Neighborhood { get; set; } = String.Empty;
        public int CityId { get; set; }
        public CityEntity City { get; set; }
    }
}
