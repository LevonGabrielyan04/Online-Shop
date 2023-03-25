﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace DataAccess.Repository.IRepository
{
	public interface IProductRepository : IRepository<Product>
	{
		void Update(Product obj);
	}
}