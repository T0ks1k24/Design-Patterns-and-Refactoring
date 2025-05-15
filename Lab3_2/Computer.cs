using System.Text;

namespace Lab3_2;

class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }
    public string PowerSupply { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine("Computer Configuration:");
        sb.AppendLine($"CPU: {CPU}");
        sb.AppendLine($"GPU: {GPU}");
        sb.AppendLine($"RAM: {RAM}");
        sb.AppendLine($"Storage: {Storage}");
        sb.AppendLine($"Power Supply: {PowerSupply}");
        return sb.ToString();
    }
}
