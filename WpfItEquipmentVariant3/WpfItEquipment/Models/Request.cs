using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItEquipment.Models
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public required int Client_Id { get; set; }
        public Client Client { get; set; }
        public required int Equipment_Id { get; set; }
        public Equipment Equipment { get; set; }
        public string Description { get; set; } = string.Empty;
        
        public RequestStatus Status { get; set; }
    }

    public enum RequestStatus
    {
        New,
        Process,
        Done
    }
}
