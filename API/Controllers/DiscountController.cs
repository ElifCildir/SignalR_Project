using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.ContactDto;
using DtoLayer.DiscountDto;
using EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {


        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {

            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountdto)
        {
            _discountService.TAdd(new Discount()
            {
              Amount = createDiscountdto.Amount,
              Description = createDiscountdto.Description,
              ImageUrl = createDiscountdto.ImageUrl,
              Title = createDiscountdto.Title,
            });

            return Ok("İndirim Bilgiisi Eklendi");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {

            var value = _discountService.TGetByID(id);
            _discountService.TDelete(value);
            return Ok("İndirim Bilgisi Silindi");

        }


        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {

            var value = _discountService.TGetByID(id);

            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            
                _discountService.TUpdate(new Discount()
            {
                Amount = updateDiscountDto.Amount,
                Description = updateDiscountDto.Description, 
                 ImageUrl = updateDiscountDto.ImageUrl,
                 Title = updateDiscountDto.Title,
                 DiscountID= updateDiscountDto.DiscountID,
              

            });

            return Ok("İndirim Bilgisi Güncellendi");




        }



    }
}
