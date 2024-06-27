using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_HAPPY_PET.Models
{
    internal interface IPetRepository
    {
        void Add(Pet pet);
        void Edit(Pet pet);
        void Delete(int id);
        IEnumerable<Pet> GotAll();
        IEnumerable<Pet> GotByValue(string vlaue); //Search
    }
}
