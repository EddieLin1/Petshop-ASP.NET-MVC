using MvcStore.Models;
using MvcStore.Repo;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcStore.Data;
using Microsoft.EntityFrameworkCore;

namespace MvcStore.Interface
{
    public interface IShoppingCart
    {
        Task<IEnumerable<ShoppingCart>> GetAllCartItemsAsync();
        Task<ShoppingCart> GetCartItemByIdAsync(int id);
        
    }
}