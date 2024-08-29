using Microsoft.EntityFrameworkCore;
using Nest;
using SalesWebMvc.Data;
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

		public void Insert(Seller obj)
		{
			_context.Seller.Add(obj);
			_context.SaveChanges();
		}
        public void Remove(Seller obj)
        {
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
		{
			return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

		public void Update(Seller obj)
		{
			_context.Seller.Update(obj);
            _context.SaveChanges();
        }
	}
}
