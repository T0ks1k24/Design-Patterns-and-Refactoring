using Lab3.absctract_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Factory
{
    class WorkstationComputerFactory : IComputerFactory
    {
        public Processor CreateProcessor() => new WorkstationProcessor();
        public Motherboard CreateMotherboard() => new WorkstationMotherboard();
        public GraphicCard CreateGraphicCard() => new WorkstationGraphicCard();
        public RAM CreateRAM() => new WorkstationRAM();
        public SSDDrive CreateSSDDrive() => new WorkstationSSD();
    }
}
