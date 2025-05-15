using Lab3.absctract_component;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Lab3;

class Computer
{
    private Processor _processor;
    private Motherboard _motherboard;
    private GraphicCard _graphicCard;
    private RAM _ram;
    private SSDDrive _ssd;

    public Computer(IComputerFactory factory)
    {
        _processor = factory.CreateProcessor();
        _motherboard = factory.CreateMotherboard();
        _graphicCard = factory.CreateGraphicCard();
        _ram = factory.CreateRAM();
        _ssd = factory.CreateSSDDrive();
    }

    public void ShowConfiguration()
    {
        _processor.ShowInfo();
        _motherboard.ShowInfo();
        _graphicCard.ShowInfo();
        _ram.ShowInfo();
        _ssd.ShowInfo();
    }
}
