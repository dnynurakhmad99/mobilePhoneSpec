using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DannyHp
{
    class Ram
    {
        private int ram;

        public Ram(int ram)
        {
            this.ram = ram;
        }

        public override string ToString()
        {
            return $"Size : {this.ram} Gb";
        }

    }
}
