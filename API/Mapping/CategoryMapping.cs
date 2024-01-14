﻿using AutoMapper;
using DtoLayer.CategoryDto;
using EntityLayer.Entities;

namespace API.Mapping
{
    public class CategoryMapping: Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetCategoryDto>().ReverseMap();
        }

    }
}
