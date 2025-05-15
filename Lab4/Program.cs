using Lab4.Docs;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report("Annual Report", "Yra Kovw", "Company performance details", "Financial");
            Article article = new Article("Tech Trends", "Anton Malchevskiy", "Latest in AI", "Technology");
            Contract contract = new Contract("Employment Contract", "Toksik Hara", "Employee agreement", "C-12345");

            Report clonedReport = (Report)report.Clone();
            clonedReport.author = "Anton Malchevskiy";
            clonedReport.content = "Updated financial details";

            Article clonedArticle = (Article)article.Clone();
            clonedArticle.author = "Yra Kovw";
            clonedArticle.content = "Deep dive into AI";

            Contract clonedContract = (Contract)contract.Clone();
            clonedContract.author = "Yra Kovw";
            clonedContract.content = "Updated contract terms";

            Console.WriteLine("Original Documents:");
            report.Display();
            article.Display();
            contract.Display();

            Console.WriteLine("Cloned and Modified Documents:");
            clonedReport.Display();
            clonedArticle.Display();
            clonedContract.Display();

            Console.ReadLine();
        }
    }
}
