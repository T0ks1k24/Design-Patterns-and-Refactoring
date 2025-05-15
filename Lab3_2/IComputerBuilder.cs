namespace Lab3_2;

interface IComputerBuilder
{
    void SetCPU();
    void SetGPU();
    void SetRAM();
    void SetStorage();
    void SetPowerSupply();
    Computer GetComputer();
}
