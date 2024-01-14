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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void TAdd(Procduct entity)
        {
            _productDal.Add(entity);
        }

        public void TDelete(Procduct entity)
        {
          _productDal.Delete(entity);
        }

        public Procduct TGetByID(int id)
        {
           return _productDal.GetByID(id);
        }

        public List<Procduct> TGetListAll()
        {
            return _productDal.GetListAll();
        }

		public List<Procduct> TGetProductsWithCategories()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Procduct entity)
        {
           _productDal.Update(entity);
        }
    }
}
