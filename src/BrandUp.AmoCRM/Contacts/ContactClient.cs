using BrandUp.AmoCRM.Contacts.Requests;
using BrandUp.AmoCRM.Contacts.Responses;

namespace BrandUp.AmoCRM.Contacts
{
    public class ContactClient
    {

    }

    public interface IContactClient
    {
        public Task<ContactQueryRequest> GetAllContactsAsync(ContactQueryRequest request, CancellationToken cancellationToken);
        public Task<Contact> GetContactByIdAsync(string id, CancellationToken cancellationToken);
        public Task<IEnumerable<Contact>> AddContactsAsync(ContactRequest[] request, CancellationToken cancellationToken);
        public Task<IEnumerable<Contact>> PatchContactsAsync(ContactRequest[] request, CancellationToken cancellationToken);
        public Task BindContactToChatAsync(ChatRequest request, CancellationToken cancellationToken);
        public Task GetContactChatsAsync(ChatRequest request, CancellationToken cancellationToken);
    }
}
