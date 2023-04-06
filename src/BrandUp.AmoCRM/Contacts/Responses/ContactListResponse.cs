using BrandUp.AmoCRM.Models;

namespace BrandUp.AmoCRM.Contacts.Responses
{
    public class ContactListResponse : BaseResponse<EmbeddedContacts>
    {
        public string Page { get; set; }
    }

    public class EmbeddedContacts
    {
        public Contact[] Contacts { get; set; }
    }
}
