using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        // Simple calculator using the strategy pattern
        // The algorithms 
        static double Add(int a, int b) => a + b;
        static double Minus(int a, int b) => a - b;
        static double Multiply(int a, int b) => a * b;
        static double Divide(int a, int b) => a / b;


        static void Main(string[] args)
        {
            double result = 0.0;
            int numOne = 0, numTwo = 0;
            string userChoice = "";

            // User input
            Console.WriteLine("First number:");
            numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number:");
            numTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choice:");
            userChoice = Console.ReadLine();

            // Entry
            while(true)
            {
                //Switch(numOne, numTwo, userChoice, result);      
                Dict(numOne, numTwo, userChoice, result);
            }

        }

        static void Switch(int numOne, int numTwo, string userChoice, double result)
        {
            // Bad: Using switch statements

            switch (userChoice)
            {
                case "+":
                    result = Add(numOne, numTwo);
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = Minus(numOne, numTwo);
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = Multiply(numOne, numTwo);
                    Console.WriteLine(result);
                    break;
                case "/":
                    result = Divide(numOne, numTwo);
                    Console.WriteLine(result);
                    break;

            }
        }

        static void Dict(int numOne, int numTwo, string userChoice, double result)
        {
            // Better: Dictionary with interface
            Dictionary<string, IMathOperator> strategies = new Dictionary<string, IMathOperator>()
            {
                {"+", new MathAdd() },
                {"-", new MathMinus() },
                {"*", new MathMultiply() },
                {"/", new MathDivide() }
            };

            IMathOperator selectedStrategy = strategies[userChoice];
            result = selectedStrategy.Operation(numOne, numTwo);
            Console.WriteLine(result);
        }

        static void FancyDict(int numOne, int numTwo, string userChoice, double result)
        {
            // Even Better: Return functions to avoid expensive instantiating
            Dictionary<string, Func<IMathOperator>> strategies = new Dictionary<string, Func<IMathOperator>>()
            {
                {"+", () => new MathAdd() },
                {"-", () => new MathMinus() },
                {"*", () => new MathMultiply() },
                {"/", () => new MathDivide() }
            };

            IMathOperator selectedStrategy = strategies[userChoice]();
            result = selectedStrategy.Operation(numOne, numTwo);
            Console.WriteLine(result);
        }
    }
}
