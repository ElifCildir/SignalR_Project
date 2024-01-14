using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService: IGenericSevice<Category>
    {
		 int TCategoryCount();

		int TActiveCategoryCount();
		int TPassiveCategoryCount();

		

    }
}
