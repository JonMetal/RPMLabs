using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItEquipment.Models
{
    public class User
    {
        public int Id { get; set; }
        public UserRole Role { get; set; }
        public string Login {  get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

    }

    public enum UserRole
    {
        Admin,
        Engineer,
        Client
    }
}
