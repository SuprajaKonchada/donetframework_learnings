using DesignPatternsDemo.State.Interfaces;

namespace DesignPatternsDemo.State.Classes
{
    public class ModerationState : IDocumentState
    {
        public void Publish(Document document)
        {
            Console.WriteLine("Document is published.");
            document.SetState(new PublishedState());  // Change state to Published
        }

        public void Reject(Document document)
        {
            Console.WriteLine("Document is rejected.");
            document.SetState(new DraftState());  // Change state back to Draft
        }
    }

}
