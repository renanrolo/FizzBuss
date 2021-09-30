using System;

namespace FizzBuss
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBussStrategy = new FizzBussStrategy();

            Console.WriteLine("Start");

            for (int i = 1; i < 100; i++)
            {
                var strategy = fizzBussStrategy.GetStrategy(i);

                strategy.Print(i);
            }

            Console.WriteLine("End!");

        }
    }

    class FizzBussStrategy
    {
        public IAction GetStrategy(int number)
        {
            var type = GetActionType(number);

            return type switch
            {
                ActionType.FizzBuss => new FizzBussAction(),
                ActionType.Fizz => new FizzAction(),
                ActionType.Buss => new BussAction(),
                _ => new DefaultAction(),
            };
        }

        private ActionType GetActionType(int number)
        {
            if (IsMultiplierOf(number, 3) && IsMultiplierOf(number, 5))
            {
                return ActionType.FizzBuss;
            }

            if (IsMultiplierOf(number, 3))
            {
                return ActionType.Fizz;
            }

            if (IsMultiplierOf(number, 5))
            {
                return ActionType.Buss;
            }

            return ActionType.Default;
        }

        private bool IsMultiplierOf(int number, int multiplier)
        {
            return number % multiplier == 0;
        }

        private enum ActionType
        {
            Default,
            FizzBuss,
            Fizz,
            Buss
        }
    }

    interface IAction
    {
        void Print(int number);
    }

    class FizzBussAction : IAction
    {
        private const string _text = "FizzBuss";

        public void Print(int number)
        {
            Console.WriteLine($"{number}: {_text}");
        }
    }

    class FizzAction : IAction
    {
        private const string _text = "Fizz";

        public void Print(int number)
        {
            Console.WriteLine($"{number}: {_text}");
        }
    }

    class BussAction : IAction
    {
        private const string _text = "Buss";

        public void Print(int number)
        {
            Console.WriteLine($"{number}: {_text}");
        }
    }

    class DefaultAction : IAction
    {
        public void Print(int number)
        {
            Console.WriteLine(number);
        }
    }
}
