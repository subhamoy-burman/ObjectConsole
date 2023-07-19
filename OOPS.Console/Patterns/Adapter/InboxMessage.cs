namespace OOPS.Console.Patterns.Adapter
{
    public class InboxMessage
    {
        public string MessageText { get; set; }

        public InboxMessage(string messageText)
        {
            MessageText = messageText;
        }
    }
}