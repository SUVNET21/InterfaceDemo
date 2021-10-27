using System;
using System.Collections.Generic;

namespace Adressbok
{
    class TestDataManager : IDataManager
    {
        public bool Save(List<Contact> contacts)
        {
            Console.WriteLine("Pretending to save data");
            return true;
        }
    }
}