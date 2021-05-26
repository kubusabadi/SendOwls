
namespace SendOwls.Models
{
    public class Input
    {
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string EmailFilePath { get; set; }
        public string RecepientsFilePath { get; set; }
        public string SmtpServer { get; set; }
    }
}