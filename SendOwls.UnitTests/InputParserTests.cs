
using Xunit;
using SendOwls.Logic.Parsers;
using SendOwls.UnitTests.Model;

namespace SendOwls.UnitTests
{
    public class inputParserTests
    {
        [Fact]
        public void InputParser_Successful()
        {
            InputParser parser = new InputParser(TestObject.InputArgs);
            var input = parser.Input;

            Assert.Equal(TestObject.TestEmailAddress, input.EmailAddress);
            Assert.Equal(TestObject.TestEmailPath, input.EmailFilePath);
            Assert.Equal(TestObject.TestRecepientsPath, input.RecepientsFilePath);
            Assert.Equal(TestObject.TestSmtpServer, input.SmtpServer);
        }
    }
}