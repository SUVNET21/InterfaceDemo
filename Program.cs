using System;
using System.Collections.Generic;

namespace Adressbok
{
    class Program
    {
        static void Main()
        {
            //Välj en av dessa två  datamanagers att skicka till contactsRepository:
            //TestDataManager dataManager = new();
            SimpleFileSaver simpleFileSaver = new();
            ContactRepository contacts = new(simpleFileSaver);
            //TODO Skapa en ny datamanager som lagrar dina contacts som JSON-data, XML-data eller binära filer
            // ELLER med hjälp av SQL-lite...

            contacts.AddContact(new Contact("Conny Contact", new DateTime(1970, 1, 1)));
            contacts.AddContact(new Contact("Jesus Svensson", new DateTime(1980, 6, 1)));
            contacts.AddContact(new Contact("Gun Gunnarsson", new DateTime(1990, 12, 30)));
        }
    }
}
