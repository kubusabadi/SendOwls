
using SendOwls.Models;

namespace SendOwls.Logic
{
    public class InputParser
    {
        public Input Input { get; private set; }

        public InputParser(string[] args)
        {
            System.Console.WriteLine("Parsing input");
        }
    }
}