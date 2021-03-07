using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcStore.Data;
using Microsoft.EntityFrameworkCore;

namespace MvcStore.Models
{
    public class PetRepo 
    {
        public int ItemType {get; set;}
        public string Name {get; set;}
        public double Price {get; set;}
        public string Description {get; set;}


    }
}