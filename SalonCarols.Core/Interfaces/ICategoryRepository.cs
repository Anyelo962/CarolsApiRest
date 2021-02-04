using SalonCarols.Core.entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SalonCarols.Core.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategories();
        Task<Category> getById(int id);

        Task addCategory(Category category);

        Task deleteCategory(int id);

      //  Task<Category> deleteById(int id);
    }
}
