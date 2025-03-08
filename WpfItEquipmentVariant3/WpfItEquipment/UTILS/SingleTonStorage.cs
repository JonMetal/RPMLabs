using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfItEquipment.UTILS
{
    class SingleTonStorage
    {
        private static readonly Storage _storage = new Storage();

        public static Storage Storage { get { return _storage; } }
    }
}
