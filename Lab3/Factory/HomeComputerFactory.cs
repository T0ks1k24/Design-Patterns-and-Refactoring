using Lab3.absctract_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Factory
{
    class HomeComputerFactory : IComputerFactory
    {
        public Processor CreateProcessor() => new HomeProcessor();
        public Motherboard CreateMotherboard() => new HomeMotherboard();
        public GraphicCard CreateGraphicCard() => new HomeGraphicCard();
        public RAM CreateRAM() => new HomeRAM();
        public SSDDrive CreateSSDDrive() => new HomeSSD();

    }
}
