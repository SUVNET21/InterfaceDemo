using System.Collections.Generic;

namespace Adressbok
{
    internal interface IDataManager
    {
        bool Save(List<Contact> contacts);
        // TODO: Lägg till en metod som laddar in en contacts-lista!
        // Skapa en load-metod i båda datamanager-klasserna. 
        // I TestDataManager kan några random kontakter läggas in
    }
}