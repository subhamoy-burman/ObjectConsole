namespace OOPS.Console.Patterns.Adapter
{
    public class MessageModel
    {
        public string Subject { get; set; }
        public string Body { get; set; }

        public MessageModel(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
    }
}