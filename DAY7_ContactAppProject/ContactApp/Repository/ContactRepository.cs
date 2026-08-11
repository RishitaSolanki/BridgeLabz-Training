// Repository stores and retrieves data.

using ContactApp.Model;

namespace ContactApp.Repository
{
    public class ContactRepository
    {

        private readonly List<Contact> contacts = new();



        public List<Contact> GetAll()
        {
            return contacts;
        }



        public Contact? GetById(int id)
        {
            return contacts.FirstOrDefault(x => x.Id == id);
        }



        public Contact? GetByPhone(string phone)
        {
            return contacts.FirstOrDefault(x => x.Phone == phone);
        }



        public void Add(Contact contact)
        {
            contact.Id = contacts.Count + 1;

            contacts.Add(contact);
        }



        public bool Update(Contact updatedContact)
        {
            var existingContact = contacts.FirstOrDefault(
                x => x.Id == updatedContact.Id
            );


            if(existingContact == null)
            {
                return false;
            }


            existingContact.Name = updatedContact.Name;
            existingContact.Email = updatedContact.Email;
            existingContact.Phone = updatedContact.Phone;


            return true;
        }



        public void Delete(Contact contact)
        {
            contacts.Remove(contact);
        }

    }
}