using DesignPatternsDemo.State.Interfaces;

namespace DesignPatternsDemo.State.Classes
{
    public class DraftState : IDocumentState
    {
        public void Publish(Document document)
        {
            Console.WriteLine("Document is submitted for moderation.");
            document.SetState(new ModerationState());  // Change state to Moderation
        }

        public void Reject(Document document)
        {
            Console.WriteLine("Draft can't be rejected.");
        }
    }

}
