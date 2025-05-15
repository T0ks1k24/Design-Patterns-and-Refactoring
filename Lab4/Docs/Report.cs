namespace Lab4.Docs;

class Report : Document
{
    public string report_type { get; set; }
    public Report(string title, string author, string content, string report_type) : base(title, author, content)
    {
        this.report_type = report_type;
    }

    public override Document Clone()
    {
        return new Report(title, author, content, report_type);
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Report Type: {report_type}");
    }
}
