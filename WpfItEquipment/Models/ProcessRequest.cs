using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItEquipment.Models
{
    public class ProcessRequest
    {
        public int Id {  get; set; }
        public required int Request_Id { get; set; }
        public required Request Request { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateEnd { get; set; }
        public required int Engineer_Id { get; set; }
        public required Engineer Engineer { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;

    }

    public enum ProcessRequestStage
    {
        WaitingSpareParts,
        Processing,
        Ready
    }
}
