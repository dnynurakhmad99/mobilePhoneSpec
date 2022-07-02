using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DannyHp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Samsung S20 Ultra Spesification :\n");

            Processor octaCore = new Processor();
            octaCore.setSeries("Octa-core (2x2.73 GHz Mongoose M5 & 2x2.60 GHz Cortex-A76 & 4x2.0 GHz Cortex-A55)");
            octaCore.setCore(8);

            Ram size = new Ram(12);

            OS android = new OS(10,"Android Q");

            Memory memory = new Memory(128, "microSD up to 1 Tb");

            Battery battery = new Battery(5000);

            Screen screen = new Screen();
            screen.setPixel("1440x3200");
            screen.setInch(6.9);

            Samsung samsung = new Samsung.Builder(octaCore, size, android, memory, battery, screen).build();
            Console.WriteLine(samsung.ToString());
        }
    }
}
