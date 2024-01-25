using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CashDeskManager : ICashDeskService
	{
		private readonly ICashDeskDal _cashDeskDal;

		public CashDeskManager(ICashDeskDal cashDeskDal)
		{
			_cashDeskDal = cashDeskDal;
		}

		public void TAdd(CashDesk entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(CashDesk entity)
		{
			throw new NotImplementedException();
		}

		public CashDesk TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<CashDesk> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public decimal TTotalCashDeskAmount()
		{
			return _cashDeskDal.TotalCashDeskAmount();
		}

		public void TUpdate(CashDesk entity)
		{
			throw new NotImplementedException();
		}
	}
}
