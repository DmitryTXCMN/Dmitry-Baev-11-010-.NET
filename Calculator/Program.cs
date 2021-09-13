using System;

namespace Calculator
{
    class Program
    {
        private static bool CheckArgsLenghtOrQuit(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine($"Programm needs 3 args, but there is {args.Length}");
                return true;
            }
            return false;
        }

        private const int NotEnoughtArgs = 1;
        private const int WrongArgFormat = 2;
        private const int WrongOperation = 3;

        static int Main(string[] args)
        {
            if (CheckArgsLenghtOrQuit(args))
                return NotEnoughtArgs;

            if (Parser.TryParsArgsOrQuit(args[0], out var val1) || Parser.TryParsArgsOrQuit(args[2], out var val2))
                return WrongArgFormat;

            if (Parser.TryParsOperatorOrQuit(args[1], out var operation))
                return WrongOperation;

            var result = Calculator.Calculate(val1, operation, val2);
            Console.WriteLine($"Result : {result}");

            return 0;
        }
    }
}