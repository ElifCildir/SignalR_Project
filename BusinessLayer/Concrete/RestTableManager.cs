using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class RestTableManager : IRestTableService
	{

		private readonly IRestTableDal _restTableDal;

		public RestTableManager(IRestTableDal restTableDal)
		{
			_restTableDal = restTableDal;
		}

		public void TAdd(RestTable entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(RestTable entity)
		{
			throw new NotImplementedException();
		}

		public RestTable TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<RestTable> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public int TRestTableCount()
		{
			return _restTableDal.RestTableCount();
		}

		public void TUpdate(RestTable entity)
		{
			throw new NotImplementedException();
		}
	}
}
