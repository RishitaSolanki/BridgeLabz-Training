using ContactApp.Model;
using ContactApp.Repository;

namespace ContactApp.Service
{
    public class ContactService
    {
        private readonly ContactRepository repository;

        public ContactService(ContactRepository repository)
        {
            this.repository = repository;
        }


        // GET ALL
        public List<Contact> GetContacts()
        {
            return repository.GetAll();
        }


        // GET BY ID
        public Contact? GetContactById(int id)
        {
            return repository.GetById(id);
        }


        // GET BY PHONE
        public Contact? GetContactByPhone(string phone)
        {
            return repository.GetByPhone(phone);
        }


        // POST
        public Contact AddContact(Contact contact)
        {
            return repository.Add(contact);
        }


        // PUT
        public bool UpdateContact(Contact contact)
        {
            return repository.Update(contact);
        }


        // DELETE
        public bool DeleteContact(int id)
        {
            return repository.Delete(id);
        }
    }
}