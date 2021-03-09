using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcStore.Models;


namespace MvcStore.Repo
{
    public class PetRepoo
    {
        public IEnumerable<Pet> GetAllPets(){
            return PetDataSource();
        }

        public Pet GetPet(int PetId)
        {
            return GetPetById(PetId);
        }
        public Pet GetPetById(int id)
        {
            return PetDataSource().Where(x => x.PetId == id).FirstOrDefault();
        }
        private IEnumerable<Pet> PetDataSource(){
            return new List<Pet>()
            {
                new Pet(){PetId = 1, Name = "Dog", Price = 499.99, Description = "Fluffy Dog goes woof"},
                new Pet(){PetId = 2, Name = "Cat", Price = 299.99, Description = "Fluffy Cat goes meow"},
                new Pet(){PetId = 3, Name = "Fish", Price = 9.99, Description = "Slimy Fish goes blub"},
                new Pet(){PetId = 4, Name = "Bird", Price = 59.99, Description = "Pretty Bird goes chirp"},
                new Pet(){PetId = 5, Name = "Snake", Price = 89.99, Description = "Long Snake goes hisss"}
            };
        }
    }
}