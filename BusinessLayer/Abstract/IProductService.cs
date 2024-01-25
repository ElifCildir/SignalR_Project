using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IProductService: IGenericSevice<Procduct>
       
    {

        List<Procduct> TGetProductsWithCategories();
        int TProductCount();
		int TProductCountByCategoryNameHamburger();

		int TProductCountByCategoryNameDrink();

        decimal TProductPriceAvg();

		string TProductNameByMaxPrice();

		string TProductNameByMinPrice();

		decimal TAvgHamburgerPrice();

	}
}
