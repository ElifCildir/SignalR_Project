﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.FeatureDto
{
    public class GetFeatureDto
    {
        [Key]
        public int FeatureID { get; set; }
        public string Title1 { get; set; }
        public string Description1 { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public string Title3 { get; set; }
        public string Description3 { get; set; }

    }
}
