﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        public string Location { get; set; }    
        public string Phone { get; set; }    
        public string Mail { get; set; }    
        public string FooterDescription { get; set; }    


    }
}
