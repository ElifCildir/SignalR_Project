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
	public class EfRestTableDal : GenericRepository<RestTable>, IRestTableDal
	{
		public EfRestTableDal(SignalRContext context) : base(context)
		{

		}

		public int RestTableCount()
		{
			using var context = new SignalRContext();
			return context.RestTables.Count();
		}
	}
}
