using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Procduct>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

		public List<Procduct> GetProductsWithCategories()
		{
			var context = new SignalRContext();
			var values = context.Procducts.Include(x => x.Category).ToList();
			return values;
		}


	}
}
