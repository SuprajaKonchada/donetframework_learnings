using DesignPatternsDemo.State.Interfaces;

namespace DesignPatternsDemo.State.Classes
{
    public class PublishedState : IDocumentState
    {
        public void Publish(Document document)
        {
            Console.WriteLine("Document is already published.");
        }

        public void Reject(Document document)
        {
            Console.WriteLine("Published document cannot be rejected.");
        }
    }

}
