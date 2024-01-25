﻿using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
	public interface IOrderDal : IGenericDal<Order>
	{

		int TotalOrderCount();
		int ActiveOrderCount();


		decimal LastOrderPrice();
	}
}
