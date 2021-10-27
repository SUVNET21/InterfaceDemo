using System.Collections.Generic;
using System.IO;
using System;

namespace Adressbok
{
    internal class SimpleFileSaver : IDataManager
    {
        //TODO: Se till att true eller false returneras beroende på om WriteAllLines genererar ett exception eller inte
        public bool Save(List<Contact> contacts)
        {
            List<string> data = new();
            foreach (var item in contacts)
            {
                data.Add(item.Name + ", " + item.BirthDate.ToShortDateString());
            }

            File.WriteAllLines("contacts.txt", data);

            Console.WriteLine("Wrote to file!");
            return true;
        }
    }
}