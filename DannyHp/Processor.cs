using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DannyHp
{
    class Processor
    {
        private String series;
        private int core;
        
        public Processor()
        { }

        public void setSeries(String series)
        {
            this.series = series;
        }

        public void setCore(int core)
        {
            this.core = core;
        }

        public override string ToString()
        {
            return $"Series : {this.series}, Core : {this.core}";
        }
    }
}
