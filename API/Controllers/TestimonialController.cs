using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.ContactDto;
using DtoLayer.TestimonialDto;
using EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {

            var value = _mapper.Map<List<ResultTestimonialDto>>(_testimonialService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            _testimonialService.TAdd(new Testimonial()
            {
               Description=createTestimonialDto.Description,
               ImageUrl=createTestimonialDto.ImageUrl,
               Name=createTestimonialDto.Name,
               Status=createTestimonialDto.Status,
               Title=createTestimonialDto.Title,
               
               

            });

            return Ok("Müşteri Yorum Bilgiisi Eklendi");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonial(int id)
        {

            var value = _testimonialService.TGetByID(id);
            _testimonialService.TDelete(value);
            return Ok("Müşteri Yorum Bilgisi Silindi");

        }


        [HttpGet("{id}")]
        public IActionResult GetTestimonial(int id)
        {

            var value = _testimonialService.TGetByID(id);

            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            _testimonialService.TUpdate(new Testimonial()
            {
                Description = updateTestimonialDto.Description,
                TestimonialID=updateTestimonialDto.TestimonialID,
                Title=updateTestimonialDto.Title,
                Status=updateTestimonialDto.Status,
                ImageUrl = updateTestimonialDto.ImageUrl,
                Name = updateTestimonialDto.Name
                


            });

            return Ok("Yorum Bilgisi Güncellendi");




        }



    }
}
