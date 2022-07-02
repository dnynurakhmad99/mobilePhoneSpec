using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DannyHp
{
    class Screen
    {
        private String pixel;
        private Double inch;

        public Screen()
        { }

        public void setPixel(String pixel)
        {
            this.pixel = pixel;
        }

        public void setInch(Double inch)
        {
            this.inch = inch;
        }

        public override string ToString()
        {
            return $"Pixel : {this.pixel}, Inch : {this.inch} inch";
        }
    }
}
