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

		public decimal TAvgHamburgerPrice()
		{
			return _productDal.AvgHamburgerPrice();
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
            return _productDal.GetProductsWithCategories();
		}

		public int TProductCount()
		{
			return _productDal.ProductCount();
		}

		public int TProductCountByCategoryNameDrink()
		{
            return _productDal.ProductCountByCategoryNameDrink();
		}

		public int TProductCountByCategoryNameHamburger()
		{
			return _productDal.ProductCountByCategoryNameHamburger();
		}

		public string TProductNameByMaxPrice()
		{
			return _productDal.ProductNameByMaxPrice();
		}

		public string TProductNameByMinPrice()
		{
			return _productDal.ProductNameByMinPrice();
		}

		public decimal TProductPriceAvg()
		{
			return _productDal.ProductPriceAvg();   
		}

		public void TUpdate(Procduct entity)
        {
           _productDal.Update(entity);
        }
    }
}
