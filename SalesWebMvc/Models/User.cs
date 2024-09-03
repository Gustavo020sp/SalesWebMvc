using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMvc.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [DataType(DataType.Password)]
        public string Password {  get; set; }
        public User()
        {
        }
        public User(int id, string userName, string password)
        {
            Id = id;
            UserName = userName;
            Password = password;
        }
    }
}
