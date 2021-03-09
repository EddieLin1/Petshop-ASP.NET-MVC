using MvcStore.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcStore.Data;
using Microsoft.EntityFrameworkCore;
using MvcStore.Models;

namespace MvcStore.Repo
{
    public class ShoppingCartRepository : IShoppingCart
    {
        private readonly StoreDBContext _context;
        public ShoppingCartRepository(StoreDBContext context){
            _context = context;
        }
        public async Task<IEnumerable<ShoppingCart>> GetAllCartItemsAsync()
        {
            return await _context.ShoppingCart.ToListAsync();
        }
        public async Task<ShoppingCart> GetCartItemByIdAsync(int id)
        {
            return await _context.ShoppingCart.FindAsync(id);
        }


    }
}