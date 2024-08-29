using SalesWebMvc.Data;
using SalesWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        //Classe personalizada do DbContext do Entity Framework
        private readonly SalesWebMvcContext _context;

        //Construtor para injeção de dependência
        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(n => n.Name).ToListAsync();
        }
    }
}
