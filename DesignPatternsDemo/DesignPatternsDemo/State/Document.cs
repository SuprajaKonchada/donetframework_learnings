using DesignPatternsDemo.State.Classes;
using DesignPatternsDemo.State.Interfaces;

namespace DesignPatternsDemo.State
{
    public class Document
    {
        private IDocumentState currentState;

        public Document()
        {
            // Initial state is Draft
            currentState = new DraftState();
        }

        public void SetState(IDocumentState state)
        {
            currentState = state;
        }

        public void Publish()
        {
            currentState.Publish(this);
        }

        public void Reject()
        {
            currentState.Reject(this);
        }

        public string GetCurrentState()
        {
            return currentState.GetType().Name;
        }
    }

}
