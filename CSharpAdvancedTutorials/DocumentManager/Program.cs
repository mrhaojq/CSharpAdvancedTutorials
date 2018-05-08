using System;
using static System.Console;

namespace DocumentManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dm = new DocumentManager<Document>();

            dm.AddDocument(new Document("Title A","Sample A") { });
            dm.AddDocument(new Document("Title B", "Sample B") { });

            dm.DisplayAllDocuments();

            if (dm.IsDocumentAvailable)
            {
                Document d = dm.GetDocument();
                WriteLine(d.Content);
            }

            ReadKey();
        }
    }
}
