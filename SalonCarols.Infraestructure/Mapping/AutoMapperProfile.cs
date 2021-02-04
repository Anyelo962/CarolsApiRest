using AutoMapper;
using SalonCarols.Core.DTOs;
using SalonCarols.Core.entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalonCarols.Infraestructure.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryDTOs>();
            CreateMap<CategoryDTOs, Category>();
        }
    }
}
