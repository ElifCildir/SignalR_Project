using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.ContactDto;
using DtoLayer.FeatureDto;
using EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IFeatureService featureService, IMapper mapper)
        {
            _featureService = featureService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {

            var value = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto feature)
        {
            _featureService.TAdd(new Feature()
            {
                Description1 = feature.Description1,
                Description2 = feature.Description2,
                Description3 = feature.Description3,
                Title1 = feature.Title1,
                Title2 = feature.Title2,
                Title3 = feature.Title3,
             
            });

            return Ok("Öne çıkan Bilgiisi Eklendi");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {

            var value = _featureService.TGetByID(id);
            _featureService.TDelete(value);
            return Ok("Öne çıkan Bilgisi Silindi");

        }


        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {

            var value = _featureService.TGetByID(id);

            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            _featureService.TUpdate(new Feature()
            { 
                Description1=updateFeatureDto.Description1,
                Description2 = updateFeatureDto.Description2,
                Description3 = updateFeatureDto.Description3,
                Title1 = updateFeatureDto.Title1,
                    Title2 = updateFeatureDto.Title2,
                    Title3 = updateFeatureDto.Title3,
                    FeatureID=updateFeatureDto.FeatureID
            

            });

            return Ok("Öne Çıkan Bilgisi Güncellendi");




        }


    }
}
