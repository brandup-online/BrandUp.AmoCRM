namespace BrandUp.AmoCRM.Contacts.Responses
{
    public class CatalogElements
    {
        public int Id { get; set; }
        public CatalogMetadata Metadata { get; set; }
    }

    public class CatalogMetadata
    {
        public int Quantity { get; set; }
        public int CatalogId { get; set; }
        public int PriceId { get; set; }
    }
}