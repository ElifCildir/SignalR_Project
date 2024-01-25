using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IProductDal: IGenericDal<Procduct>
    {
        List<Procduct> GetProductsWithCategories();

        public int ProductCount();

		int ProductCountByCategoryNameHamburger();

		int ProductCountByCategoryNameDrink();

        decimal ProductPriceAvg();

        string ProductNameByMaxPrice();

		string ProductNameByMinPrice();

        decimal AvgHamburgerPrice();



	}
}
