using AutoMapper;
using DtoLayer.ContactDto;
using EntityLayer.Entities;

namespace API.Mapping
{
    public class ContactMapping:Profile

    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();

    }
}
}