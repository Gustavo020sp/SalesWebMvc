﻿using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
	public class SellerService
	{
		//Classe personalizada do DbContext do Entity Framework
		private readonly SalesWebMvcContext _context;

		//Construtor para injeção de dependência
		public SellerService(SalesWebMvcContext context)
		{
			_context = context;
		}

		public List<Seller> FindAll()
		{
		    return _context.Seller.ToList();	
		}


	}
}
