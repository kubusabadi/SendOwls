
using SendOwls.Models;

namespace SendOwls.Logic.Managers
{
    public class MailingManager
    {
        private readonly Input _input;
        public MailingManager(Input input)
        {
            _input = input;
        }
    }
}