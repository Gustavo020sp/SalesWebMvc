namespace SalesWebMvc.Models
{
    public class Seller
    {
        //ATTRIBUTES
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public int DepartmentId {  get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();


        //CONSTRUCTORS
        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        //METHODS
        public void AddSales(SalesRecord sr) 
        { 
            SalesRecords.Add(sr);
        }
        public void RemoveSales(SalesRecord sr)
        {
            SalesRecords.Remove(sr);
        }

        //Calcula total de vendas de um vendedor
        public double TotalSales(DateTime initial, DateTime final)
        {
            return SalesRecords.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }

    }
}
