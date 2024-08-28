using SalesWebMvc.Data;
using SalesWebMvc.Models;

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

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(n => n.Name).ToList();
        }
    }
}
