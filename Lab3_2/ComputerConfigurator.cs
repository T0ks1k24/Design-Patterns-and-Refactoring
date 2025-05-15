namespace Lab3_2;

class ComputerConfigurator
{
    public Computer Construct(IComputerBuilder builder)
    {
        builder.SetCPU();
        builder.SetGPU();
        builder.SetRAM();
        builder.SetStorage();
        builder.SetPowerSupply();
        return builder.GetComputer();
    }
}
