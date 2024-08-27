namespace SalesWebMvc.Models
{
    public class Department
    {
        //ATTRIBUTES
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        //CONSTRUCTORS
        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        //METHODS
        public void AddSeller(Seller seller) 
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Select(s => s.TotalSales(initial, final)).Sum();
        }
    }
}
