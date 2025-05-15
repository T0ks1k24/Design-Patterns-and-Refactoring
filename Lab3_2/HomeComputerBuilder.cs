namespace Lab3_2;

class HomeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetCPU() => _computer.CPU = "Intel Core i5";
    public void SetGPU() => _computer.GPU = "Integrated Intel UHD Graphics";
    public void SetRAM() => _computer.RAM = "16GB DDR4";
    public void SetStorage() => _computer.Storage = "512GB SSD";
    public void SetPowerSupply() => _computer.PowerSupply = "500W";

    public Computer GetComputer() => _computer;
}
