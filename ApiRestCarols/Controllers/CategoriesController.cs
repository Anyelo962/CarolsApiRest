using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalonCarols.Core.DTOs;
using SalonCarols.Core.entities;
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
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> getCategories()
        {
            var category = await categoryRepository.GetCategories();
            var categoryDTO = _mapper.Map<IEnumerable<CategoryDTOs>>(category);

            return Ok(categoryDTO);
        }
        [HttpPost]
        public async Task<IActionResult> addCategory (CategoryDTOs category)
        {
            //var categoryPost = new Category
            //{
            //    NameProduct = category.NameProduct
            //};

            var postCategory = _mapper.Map<Category>(category);
            await categoryRepository.addCategory(postCategory);

            return Ok(postCategory);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getByIdCategory(int id)
        {
            var getById = await categoryRepository.getById(id);
            //var categoryById = new CategoryDTOs
            //{
            //    NameProduct = getById.NameProduct
            //};
            var categoryById = _mapper.Map<Category>(getById);
            return Ok(categoryById);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteCategory(int id)
        {

            await categoryRepository.deleteCategory(id);

            return Ok(id);
        }
    }
}
