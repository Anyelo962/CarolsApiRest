using SalonCarols.Core.entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalonCarols.Core.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
    }
}
