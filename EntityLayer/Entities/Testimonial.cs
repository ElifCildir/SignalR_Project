using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Testimonial
    {
        [Key]
        public int TestimonialID { get; set; }
        public string  Name { get;set; }
        public string Title  { get;set; }
        public string Description { get;set; }
        public string ImageUrl { get;set; }
        public bool  Status { get;set; }
         
    }
}
