﻿using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfCatergoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCatergoryDal(SignalRContext context) : base(context)
        {
        }
    }
}
