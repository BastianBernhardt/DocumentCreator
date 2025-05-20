using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentCreator
{
    public class DocumentGenerator
    {
        public void Generate(string path, bool includeGreeting, bool includeBody, bool includeConclusion)
        {
            using var wordDoc = WordprocessingDocument.Create(path, WordprocessingDocumentType.Document);
            var mainPart = wordDoc.AddMainDocumentPart();
            mainPart.Document = new Document(new Body());
            var body = mainPart.Document.Body;

            if (includeGreeting)
            {
                body.AppendChild(new Paragraph(new Run(new Text("Hello!"))));
            }

            if (includeBody)
            {
                body.AppendChild(new Paragraph(new Run(new Text("This is the body content."))));
            }

            if (includeConclusion)
            {
                body.AppendChild(new Paragraph(new Run(new Text("Best regards."))));
            }

            mainPart.Document.Save();
        }
    }
}
