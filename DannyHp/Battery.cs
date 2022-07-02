using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DannyHp
{
    class Battery
    {
        private int battery;

        public Battery(int battery)
        {
            this.battery = battery;
        }

        public override string ToString()
        {
            return $"Size : {this.battery} mAH";
        }
    }
}
