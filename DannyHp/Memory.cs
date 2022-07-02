using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DannyHp
{
    class Memory
    {
        private int dalam;
        private String luar;

        public Memory(int dalam, String luar)
        {
            this.dalam = dalam;
            this.luar = luar;
        }

        public override string ToString()
        {
            return $"Internal : {this.dalam} Gb, External : {this.luar}";
        }

    }
}
