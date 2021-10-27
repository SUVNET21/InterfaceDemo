using System;

namespace Adressbok
{
    class Contact
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Contact(string name, DateTime bd)
        {
            Name = name;
            BirthDate = bd;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}