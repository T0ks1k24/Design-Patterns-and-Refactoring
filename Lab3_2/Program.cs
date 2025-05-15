namespace Lab3_2;

internal class Program
{
    static void Main(string[] args)
    {
        ComputerConfigurator configurator = new ComputerConfigurator();

        IComputerBuilder homeBuilder = new HomeComputerBuilder();
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        IComputerBuilder workstationBuilder = new WorkstationComputerBuilder();

        Computer homePC = configurator.Construct(homeBuilder);
        Computer gamingPC = configurator.Construct(gamingBuilder);
        Computer workstationPC = configurator.Construct(workstationBuilder);

        Console.WriteLine(homePC);
        Console.WriteLine(gamingPC);
        Console.WriteLine(workstationPC);

        Console.ReadLine();
    }
}
