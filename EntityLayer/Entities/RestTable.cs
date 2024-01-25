using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class RestTable
	{
		[Key]
        public int MenuTableID { get; set; }
		public string Name { get; set; }
		public bool  Status { get; set; }

    }
}
