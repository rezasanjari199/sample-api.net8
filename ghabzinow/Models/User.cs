using System.ComponentModel.DataAnnotations;
using System.Data;

namespace ghabzinow.Models
{
    [Serializable]
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public double Wallet { get; set; }

    }
}
