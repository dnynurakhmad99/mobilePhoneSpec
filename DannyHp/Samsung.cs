using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DannyHp
{
    class Samsung
    {
        private Processor processor;
        private Ram ram;
        private OS os;
        private Memory memory;
        private Battery battery;
        private Screen screen;

        private Samsung(Builder builder)
        {
            this.processor = builder.processor;
            this.ram = builder.ram;
            this.os = builder.os;
            this.memory = builder.memory;
            this.battery = builder.battery;
            this.screen = builder.screen;
        }

        public override string ToString()
        {
            return $"Processor spec : {this.processor}\n" +
            $"Ram spec: {this.ram}\n" +
            $"OS spec: {this.os}\n" +
            $"Memory spec: {this.memory}\n" +
            $"Battery spec: {this.battery}\n" +
            $"Screen spec: {this.screen}";
        }

        public class Builder
        {
            public Processor processor;
            public Ram ram;
            public OS os;
            public Memory memory;
            public Battery battery;
            public Screen screen;

            public Builder(Processor processor, Ram ram, OS os, Memory memory, Battery battery, Screen screen)
            {
                this.processor = processor;
                this.ram = ram;
                this.os = os;
                this.memory = memory;
                this.battery = battery;
                this.screen = screen;
            }

            public Samsung build()
            {
                return new Samsung(this);
            }
        }
    }
}
