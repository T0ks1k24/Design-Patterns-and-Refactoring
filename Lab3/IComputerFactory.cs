using Lab3.absctract_component;

namespace Lab3;

interface IComputerFactory
{
    Processor CreateProcessor();
    Motherboard CreateMotherboard();
    GraphicCard CreateGraphicCard();
    RAM CreateRAM();
    SSDDrive CreateSSDDrive();
}
