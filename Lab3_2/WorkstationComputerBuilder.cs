namespace Lab3_2;

class WorkstationComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetCPU() => _computer.CPU = "AMD Ryzen 9";
    public void SetGPU() => _computer.GPU = "NVIDIA RTX 3090";
    public void SetRAM() => _computer.RAM = "64GB DDR4";
    public void SetStorage() => _computer.Storage = "2TB NVMe SSD";
    public void SetPowerSupply() => _computer.PowerSupply = "1000W Platinum";

    public Computer GetComputer() => _computer;
}
