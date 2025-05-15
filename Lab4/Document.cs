using System;

namespace Lab4;

abstract class Document
{
    public string title { get; set; }
    public string author { get; set; }
    public string content { get; set; }

    public Document(string title, string author, string content)
    {
        this.title = title;
        this.author = author;
        this.content = content;
    }

    public abstract Document Clone();

    public virtual void Display()
    {
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Content: {content}");
    }
}
