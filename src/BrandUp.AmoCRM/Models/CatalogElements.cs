namespace BrandUp.AmoCRM.Models
{
    public class CatalogElements
    {
        public int Id { get; set; }
    }

    public class CatalogMetadata
    {
        public int Quantity { get; set; }
        public int CataloId { get; set; }
        public int PriceId { get; set; }
    }
}