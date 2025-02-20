using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItEquipment.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;   
        public string Telephone { get; set; } = string.Empty;
    }
}
