using ContactApp.Model;
using Microsoft.EntityFrameworkCore;

namespace ContactApp.Repository
{
    public class ContactRepository
    {
        private readonly ContactDbContext context;

        public ContactRepository(ContactDbContext context)
        {
            this.context = context;
        }


        // GET ALL
        public List<Contact> GetAll()
        {
            return context.Contacts.ToList();
        }


        // GET BY ID
        public Contact? GetById(int id)
        {
            return context.Contacts
                .FirstOrDefault(x => x.Id == id);
        }


        // GET BY PHONE
        public Contact? GetByPhone(string phone)
        {
            return context.Contacts
                .FirstOrDefault(x => x.Phone == phone);
        }


        // POST
        public Contact Add(Contact contact)
        {
            context.Contacts.Add(contact);
            context.SaveChanges();

            return contact;
        }


        // PUT
        public bool Update(Contact updatedContact)
        {
            var existingContact = context.Contacts
                .FirstOrDefault(x => x.Id == updatedContact.Id);

            if (existingContact == null)
            {
                return false;
            }

            existingContact.Name = updatedContact.Name;
            existingContact.Email = updatedContact.Email;
            existingContact.Phone = updatedContact.Phone;

            context.SaveChanges();

            return true;
        }


        // DELETE
        public bool Delete(int id)
        {
            var contact = context.Contacts
                .FirstOrDefault(x => x.Id == id);

            if (contact == null)
            {
                return false;
            }

            context.Contacts.Remove(contact);
            context.SaveChanges();

            return true;
        }
    }
}