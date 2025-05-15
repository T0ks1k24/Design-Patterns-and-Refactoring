namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDocumentFactory pdfFactory = new PDFDocumentFactory();
            IDocument pdf = pdfFactory.CreateDocument();
            pdf.Open();

            IDocumentFactory wordFactory = new WordDocumentFactory();
            IDocument word = wordFactory.CreateDocument();
            word.Open();

            pdf.Close();
            word.Close();
        }
    }

    public interface IDocument
    {
        void Open();
        void Close();
    }

    public class PDFDocument : IDocument
    {
        public void Open() {
            Console.WriteLine("Open PDF document");
        }

        public void Close() {
            Console.WriteLine("Close PDF document");
        }
    }

    public class WordDocument : IDocument
    {
        public void Open() {
            Console.WriteLine("Open Word document");
        }

        public void Close() {
            Console.WriteLine("Close Word document");
        }
    }
    
    public interface IDocumentFactory
    {
        IDocument CreateDocument();
    }

    public class PDFDocumentFactory : IDocumentFactory
    {
        public IDocument CreateDocument() {
            return new PDFDocument();
        }
    }

    public class WordDocumentFactory : IDocumentFactory
    {
        public IDocument CreateDocument() {
            return new WordDocument();
        }
    }
}
