using MvcStore.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcStore.Data;
using Microsoft.EntityFrameworkCore;
using MvcStore.Models;

namespace MvcStore.Repo
{
    public class PetRepository : IPetRepository
    {
        private readonly StoreDBContext _context;
        public PetRepository(StoreDBContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Pet>> GetAllPetsAsync()
        {
            return await _context.PetRepo.ToListAsync();
        }
        public async Task<Pet> GetPetByIdAsync(int id)
        {
            return await _context.PetRepo.FindAsync(id);
        }
    }
}