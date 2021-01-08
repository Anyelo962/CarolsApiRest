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
       public async Task<IEnumerable<Categoria>> GetCategories()
        {
            var categorie = await carolDBContext.Categoria.ToListAsync();

            return categorie;
        }
    }
}
