using Lab3.absctract_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Factory
{
    class GamingComputerFactory : IComputerFactory
    {
        public Processor CreateProcessor() => new GamingProcessor();
        public Motherboard CreateMotherboard() => new GamingMotherboard();
        public GraphicCard CreateGraphicCard() => new GamingGraphicCard();
        public RAM CreateRAM() => new GamingRAM();
        public SSDDrive CreateSSDDrive() => new GamingSSD();
    }
}
