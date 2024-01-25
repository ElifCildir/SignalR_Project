using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
	public class EfCashDeskDal : GenericRepository<CashDesk>,ICashDeskDal
	{
		public EfCashDeskDal(SignalRContext context) : base(context)
		{


		}

		public decimal TotalCashDeskAmount()
		{
			using var context = new SignalRContext();
			return context.CashDesks.Select(x=>x.TotalAmount).FirstOrDefault();
		}
	}
}
