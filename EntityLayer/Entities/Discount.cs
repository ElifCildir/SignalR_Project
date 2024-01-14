﻿using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Entities
{
    public class Discount
    {
        [Key]
        public int DiscountID { get; set; }
        public string Title { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
