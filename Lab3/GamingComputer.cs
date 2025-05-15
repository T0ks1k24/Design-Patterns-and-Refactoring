using Lab3.absctract_component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3;

class GamingProcessor : Processor { public override void ShowInfo() => Console.WriteLine("Gaming PC Processor: Intel i9"); }
class GamingMotherboard : Motherboard { public override void ShowInfo() => Console.WriteLine("Gaming PC Motherboard: MSI Z690"); }
class GamingGraphicCard : GraphicCard { public override void ShowInfo() => Console.WriteLine("Gaming PC Graphic Card: NVIDIA RTX 4090"); }
class GamingRAM : RAM { public override void ShowInfo() => Console.WriteLine("Gaming PC RAM: 32GB DDR5"); }
class GamingSSD : SSDDrive { public override void ShowInfo() => Console.WriteLine("Gaming PC SSD: 1TB NVMe"); }
