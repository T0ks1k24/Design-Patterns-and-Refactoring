namespace Lab3_2;

class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetCPU() => _computer.CPU = "Intel Core i9";
    public void SetGPU() => _computer.GPU = "NVIDIA RTX 4080";
    public void SetRAM() => _computer.RAM = "32GB DDR5";
    public void SetStorage() => _computer.Storage = "1TB NVMe SSD";
    public void SetPowerSupply() => _computer.PowerSupply = "850W Gold";

    public Computer GetComputer() => _computer;
}
