using Lab3.absctract_component;

namespace Lab3;

class HomeProcessor : Processor { public override void ShowInfo() => Console.WriteLine("Home PC Processor: Intel i5"); }
class HomeMotherboard : Motherboard { public override void ShowInfo() => Console.WriteLine("Home PC Motherboard: ASUS B450"); }
class HomeGraphicCard : GraphicCard { public override void ShowInfo() => Console.WriteLine("Home PC Graphic Card: Intel UHD 630"); }
class HomeRAM : RAM { public override void ShowInfo() => Console.WriteLine("Home PC RAM: 16GB DDR4"); }
class HomeSSD : SSDDrive { public override void ShowInfo() => Console.WriteLine("Home PC SSD: 512GB NVMe"); }
