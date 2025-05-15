namespace Lab4.Docs;

class Article : Document
{
    public string category { get; set; }
    public Article(string title, string author, string content, string category) : base(title, author, content)
    {
        this.category = category;
    }

    public override Document Clone()
    {
        return new Article(title, author, content, category);
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine($"Category: {category}");
    }
}
