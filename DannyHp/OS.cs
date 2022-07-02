using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DannyHp
{
    class OS
    {
        private int version;
        private String series;

        public OS(int version, String series)
        {
            this.version = version;
            this.series = series;
        }

        public override string ToString()
        {
            return $"Version : {this.version}, Series : {this.series}";
        }
    }
}
