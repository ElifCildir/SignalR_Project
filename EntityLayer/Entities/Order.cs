﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
	public class Order
	{
		public int OrderID { get; set; }
		public int TableNumber { get; set; }

		public string Description { get; set; }

		public DateTime Date { get; set; }
		public decimal TotalPrice { get; set; }

		public List<OrderDetail> OrderDetails { get; set; }



	}
}







