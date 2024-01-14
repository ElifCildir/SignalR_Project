﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Abstract;
using DtoLayer.BookingDto;
using EntityLayer.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }


        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListAll();
            return Ok(values);  
        
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail=createBookingDto.Mail,
                Date=createBookingDto.Date,
                Name=createBookingDto.Name,
                PersonCount=createBookingDto.PersonCount,
                Phone=createBookingDto.Phone,

            };

            _bookingService.TAdd(booking);
            return Ok("Rezervasyon yapıldı");

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        { 
           var value = _bookingService.TGetByID(id);  
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        
        }


        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            Booking booking = new Booking()
            {
                Mail = updateBookingDto.Mail,
                BookingID=updateBookingDto.BookingID,
                Name=updateBookingDto.Name,
                PersonCount=updateBookingDto.PersonCount,
                Phone = updateBookingDto.Phone,
                Date  =updateBookingDto.Date,

            };
        _bookingService.TUpdate(booking);
            return Ok("Rezervasyon Güncellendi");



        }


        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _bookingService.TGetByID(id);
            return Ok(value);

        }




    }
}
