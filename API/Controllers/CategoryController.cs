using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.CategoryDto;
using EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList() 
        {

            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);
        }





        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto categoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = categoryDto.CategoryName,
                Status = true


            }); 

            return Ok("Kategori Eklendi");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        { 
        
          var value=_categoryService.TGetByID(id);
        _categoryService.TDelete(value);
            return Ok("Kategori Silindi");
        
        }


        [HttpGet("{id}")]
        public IActionResult GetCategory(int id) 
        {

            var value = _categoryService.TGetByID(id);
            
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto categoryDto)
        {
            _categoryService.TUpdate(new Category()
            {    
                CategoryID=categoryDto.CategoryID,
                CategoryName = categoryDto.CategoryName,
                Status = categoryDto.Status,


            });

            return Ok("Kategori Güncellendi");




        }



    }
}
