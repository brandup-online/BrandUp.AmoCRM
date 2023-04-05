namespace BrandUp.AmoCRM.Models
{
    public class Contact : BaseResponse<ContactEmbedded>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ResponsibleUserId { get; set; }
        public int GroupId { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ClosestTaskAt { get; set; }
        public int AccountId { get; set; }
    }

    public class ContactEmbedded
    {
        public Tags[] Tags { get; set; }
        public Embedded[] Companies { get; set; }
        public Embedded[] Leads { get; set; }
        public CatalogElements[] CatalogElements { get; set; }
    }
}
