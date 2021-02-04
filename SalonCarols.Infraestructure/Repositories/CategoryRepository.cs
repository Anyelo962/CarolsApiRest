using Microsoft.EntityFrameworkCore;
using SalonCarols.Core.entities;
using SalonCarols.Core.Interfaces;
using SalonCarols.Infraestructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonCarols.Infraestructure.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly SalonCarolDBContext carolDBContext;

        public CategoryRepository(SalonCarolDBContext carolDBContext)
        {
            this.carolDBContext = carolDBContext;
        }

        public async Task<Category> getById(int id)
        {
            var getCategory = await carolDBContext.Categoria.FirstOrDefaultAsync(x => x.IdCategory == id);

            return getCategory;
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categorie = await carolDBContext.Categoria.ToListAsync();
           
            return categorie;
        }

        public async Task addCategory(Category category)
        {
            carolDBContext.Add(category);
            await carolDBContext.SaveChangesAsync();
        }

        public async Task deleteCategory(int id)  
        {
            var delete = carolDBContext.Categoria.Where(x => x.IdCategory == id);

            carolDBContext.Remove(delete);
        }
    }
}
