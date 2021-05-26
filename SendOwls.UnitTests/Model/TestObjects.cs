
namespace SendOwls.UnitTests.Model
{
    public static class TestObject
    {
        public static readonly int InputParserArgsCount = 4;
        public static readonly string TestEmailAddress = "test@test.com";
        public static readonly string TestEmailPath = "testEmail.txt";
        public static readonly string TestRecepientsPath = "testRecepients.csv"; 
        public static readonly string TestSmtpServer = "smtp.google.com"; 
        public static readonly string[] InputArgs = { TestEmailAddress, TestEmailPath, TestRecepientsPath, TestSmtpServer };
    }
}