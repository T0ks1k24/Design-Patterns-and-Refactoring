using Lab3.absctract_component;

namespace Lab3;

class WorkstationProcessor : Processor { public override void ShowInfo() => Console.WriteLine("Workstation PC Processor: AMD Ryzen Threadripper"); }
class WorkstationMotherboard : Motherboard { public override void ShowInfo() => Console.WriteLine("Workstation PC Motherboard: ASUS Pro WS WRX80"); }
class WorkstationGraphicCard : GraphicCard { public override void ShowInfo() => Console.WriteLine("Workstation PC Graphic Card: NVIDIA Quadro RTX 6000"); }
class WorkstationRAM : RAM { public override void ShowInfo() => Console.WriteLine("Workstation PC RAM: 64GB DDR5"); }
class WorkstationSSD : SSDDrive { public override void ShowInfo() => Console.WriteLine("Workstation PC SSD: 2TB NVMe"); }

