using System;
using SendOwls.Logic.Managers;
using SendOwls.Logic.Parsers;

using SendOwls.Models;
using System.Security;
namespace SendOwls
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputParser inputParser = new InputParser(args);
                Input input = inputParser.Input;

                System.Console.WriteLine("Owls are warming up right now!");
                System.Console.WriteLine("Sending with email address: " + input.EmailAddress);

                MailBodyParser bodyParser = new MailBodyParser(input.EmailFilePath);
                System.Console.WriteLine("Sending with email from: " + input.EmailFilePath);

                RecepientsParser csvParser = new RecepientsParser(input.RecepientsFilePath);
                System.Console.WriteLine("Recepients from: " + input.RecepientsFilePath + ", Count: " + csvParser.Values.Count);

                System.Console.WriteLine("Using SMTP Server: " + input.SmtpServer);

                MailingManager mailingManager = new MailingManager(input);
            }
            catch(ArgumentException ex)
            {
                printHelp();
            }          
        }

        private static void printHelp()
        {
            System.Console.WriteLine("SendOwls.exe arg1 arg2 arg3");
        }

        public SecureString GetPassword()
        {
            var pwd = new SecureString();
            while (true)
            {
                ConsoleKeyInfo i = Console.ReadKey(true);
                if (i.Key == ConsoleKey.Enter)
                {
                    break;
                }
                else if (i.Key == ConsoleKey.Backspace)
                {
                    if (pwd.Length > 0)
                    {
                        pwd.RemoveAt(pwd.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else if (i.KeyChar != '\u0000' ) // KeyChar == '\u0000' if the key pressed does not correspond to a printable character, e.g. F1, Pause-Break, etc
                {
                    pwd.AppendChar(i.KeyChar);
                    Console.Write("*");
                }
            }
            return pwd;
        }
    }
}
