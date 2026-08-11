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



        public List<Contact> GetContacts()
        {
            return repository.GetAll();
        }



        public Contact GetContactById(int id)
        {
            return repository.GetById(id);
        }



        public Contact GetContactByPhone(string phone)
        {
            return repository.GetByPhone(phone);
        }



        public void AddContact(Contact contact)
        {
            repository.Add(contact);
        }



        public bool UpdateContact(Contact contact)
        {
            return repository.Update(contact);
        }



        public void DeleteContact(int id)
        {
            var contact = repository.GetById(id);

            if(contact != null)
            {
                repository.Delete(contact);
            }
        }

    }
}