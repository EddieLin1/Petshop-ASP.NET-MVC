using Microsoft.EntityFrameworkCore;
using MvcStore.Models;

namespace MvcStore.Data
{
    public class MvcStoreContext : DbContext
    {
        public MvcStoreContext (DbContextOptions<MvcStoreContext> options)
            : base(options)
        {
        }

        public DbSet<Pet> Pet { get; set; }
    }
}