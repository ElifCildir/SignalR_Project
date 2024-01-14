using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.CategoryDto;
using DtoLayer.ContactDto;
using EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {

            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContectDto)
        {
            _contactService.TAdd(new Contact()
            {
                FooterDescription = createContectDto.FooterDescription,
                Location = createContectDto.Location,
                Mail = createContectDto.Mail,
                Phone = createContectDto.Phone

            });

            return Ok("İletişim Bilgiisi Eklendi");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {

            var value = _contactService.TGetByID(id);
            _contactService.TDelete(value);
            return Ok("İletşim Bilgisi Silindi");

        }


        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {

            var value = _contactService.TGetByID(id);

            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
               ContactID = updateContactDto.ContactID,
               FooterDescription=updateContactDto.FooterDescription,
               Location = updateContactDto.Location,
               Mail = updateContactDto.Mail,
               Phone = updateContactDto.Phone

            });

            return Ok("İletişim Bilgisi Güncellendi");




        }



    }
}
