using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class SalesRecordService
    {
        //Classe personalizada do DbContext do Entity Framework
        private readonly SalesWebMvcContext _context;

        //Construtor para injeção de dependência
        public SalesRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }
        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? mindate, DateTime? maxdate)
        {
            return await _context.SalesRecord.Include(i => i.Seller).Include(d => d.Seller.Department).Where(d => d.Date >= mindate && d.Date <= maxdate).ToListAsync();
        }
        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? mindate, DateTime? maxdate)
        {
            var result = from obj in _context.SalesRecord select obj;

            return await result.Include(x => x.Seller).
                Include(x => x.Seller.Department).
                OrderByDescending(x => x.Date).
                GroupBy(x => x.Seller.Department).ToListAsync();
        }
    }
}

