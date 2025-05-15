namespace Lab4.Docs;

class Contract : Document
{
    public string contract_number { get; set; }
    
    public Contract(string title, string author, string content, string contract_number) : base(title, author, content)
    {
        this.contract_number = contract_number;
    }

    public override Document Clone()
    {
        return new Contract(title,author,content,contract_number);
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Contract Number: {contract_number}");
    }
}
