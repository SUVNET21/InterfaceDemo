using System;
using System.Collections.Generic;
using System.Linq;

namespace Adressbok
{
    class ContactRepository
    {
        List<Contact> contacts = new();

        IDataManager datamanager;

        public ContactRepository(IDataManager datamanager)
        {
            this.datamanager = datamanager;
        }

        public void AddContact(Contact newContact)
        {
            contacts.Add(newContact);
            SaveChanges();
        }

        private void SaveChanges()
        {
            datamanager.Save(contacts);
        }

        public IList<Contact> GetAllContacts()
        {
            return contacts.AsReadOnly();
        }

        public List<Contact> GetContactByName(string searchTerm)
        {
            return contacts.Where(c => c.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}