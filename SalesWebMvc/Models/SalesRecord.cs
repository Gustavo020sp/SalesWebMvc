using SalesWebMvc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Amount { get; set; }
        public int SellerId {  get; set; }
        public Seller Seller { get; set; }
        public SaleStatus Status { get; set; }

        public SalesRecord()
        {
        }

        public SalesRecord(int id, DateTime date, double amount, Seller seller, SaleStatus status)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Seller = seller;
            Status = status;
        }
    }
}
