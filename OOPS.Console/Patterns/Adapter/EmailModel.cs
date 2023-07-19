namespace OOPS.Console.Patterns.Adapter
{
    public class EmailModel
    {
        public string Subject { get; set; }
        public string Body { get; set; }

        public EmailModel(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
    }
}