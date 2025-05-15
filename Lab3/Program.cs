using Lab3.Factory;

namespace Lab3;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Home Computer Configuration:");
        Computer homePC = new Computer(new HomeComputerFactory());
        homePC.ShowConfiguration();

        Console.WriteLine("\nGaming Computer Configuration:");
        Computer gamingPC = new Computer(new GamingComputerFactory());
        gamingPC.ShowConfiguration();

        Console.WriteLine("\nWorkstation Computer Configuration:");
        Computer workstationPC = new Computer(new WorkstationComputerFactory());
        workstationPC.ShowConfiguration();

        Console.ReadKey();
    }
}
