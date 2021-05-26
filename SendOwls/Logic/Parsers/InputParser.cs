
using System;
using SendOwls.Models;

namespace SendOwls.Logic.Parsers
{
    public class InputParser
    {
        private static readonly int ARGS_COUNT = 4;
        public Input Input { get; private set; }

        public InputParser(string[] args)
        {
            if (args.Length != ARGS_COUNT)
            {
                throw new ArgumentException("Invalid parameters provided!");
            }
            else
            {
                Input = new Input 
                {
                    EmailAddress = args[0],
                    EmailFilePath = args[1],
                    RecepientsFilePath = args[2],
                    SmtpServer = args[3]
                };
            }
        }
    }
}