using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItEquipment.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Model { get; set; } = string.Empty;
        public EquipmentType Type { get; set; }
    }

    public enum EquipmentType
    {
        Computer,
        Server,
        Printer,
        Peripheral
    }
}
