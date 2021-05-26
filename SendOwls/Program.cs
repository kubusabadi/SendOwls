using System;
using SendOwls.Logic;
using SendOwls.Models;

namespace SendOwls
{
    class Program
    {
        static void Main(string[] args)
        {
            InputParser inputParser = new InputParser(args);
            Input input = inputParser.Input;          
        }
    }
}
