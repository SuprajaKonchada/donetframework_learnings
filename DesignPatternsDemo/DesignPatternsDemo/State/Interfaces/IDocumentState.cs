namespace DesignPatternsDemo.State.Interfaces
{
    public interface IDocumentState
    {
        void Publish(Document document);
        void Reject(Document document);
    }

}
