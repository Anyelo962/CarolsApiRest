using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalonCarols.Core.Interfaces;
using SalonCarols.Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestCarols.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoriesController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<IActionResult> getCategories()
        {
            var category = await categoryRepository.GetCategories();

            return Ok(category);
        }
    }
}
