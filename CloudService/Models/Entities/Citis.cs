namespace CloudService.Models.Entities
{
    public class Citis
    {
        public int Id { get; set; }
        public required string CityName { get; set; } = string.Empty;

        // Description of the city Is nullable
        public string ? CityDescription { get; set; }

    }
}
