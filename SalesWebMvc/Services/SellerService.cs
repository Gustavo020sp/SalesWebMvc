using Microsoft.EntityFrameworkCore;
using Nest;
using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System.Runtime.CompilerServices;

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

		public async Task<List<Seller>> FindAllAsync()
		{
		    return await _context.Seller.ToListAsync();

        }

		public async Task InsertAsync(Seller obj)
		{
			_context.Seller.Add(obj);
			await _context.SaveChangesAsync();
		}
        public async Task RemoveAsync(Seller obj)
        {
            _context.Seller.Remove(obj);
            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
		{
			return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(obj => obj.Id == id);
        }

		public async Task UpdateAsync(Seller obj)
		{
			_context.Seller.Update(obj);
            await _context.SaveChangesAsync();
        }
	}
}
