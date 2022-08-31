using System;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = 1;
            while (repeat == 1)
            {
                Console.Clear();
                Console.WriteLine("**My First Calculator**");
                Console.WriteLine("*He can +,-,/,*,%,sqrt*");
                Console.Write("**Enter first value =");
                double firstValue = Convert.ToDouble(Console.ReadLine());
                Console.Write("*Сhoose an operation-");
                var operation = Console.ReadLine();
                Console.Write("**Enter second value =");
                double secondValue = Convert.ToDouble(Console.ReadLine());
                double result;
                switch (operation)
                {
                    case "+":
                        result = firstValue + secondValue;
                        Console.WriteLine($"Your result {result}");
                        break;
                    case "-":
                        result = firstValue * secondValue;
                        Console.WriteLine($"Your result {result}");
                        break;
                    case "/":
                        result = firstValue / secondValue;
                        Console.WriteLine($"Your result {result}");
                        break;
                    case "*":
                        result = firstValue * secondValue;
                        Console.WriteLine($"Your result {result}");
                        break;
                    case "%":
                        result = firstValue % secondValue;
                        Console.WriteLine($"Your result {result}");
                        break;
                    case "sqrt":
                        firstValue = Math.Sqrt(firstValue);
                        secondValue = Math.Sqrt(secondValue);
                        Console.WriteLine($"Your result {firstValue} and {secondValue}");
                        break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }
                Console.WriteLine("**Do your want again?**");
                Console.WriteLine("**If YES enter - 1 **");
                Console.WriteLine("**If NO enter any number (only number!) **");
                repeat = Convert.ToInt32(Console.ReadLine());
                if (repeat != 1)
                {
                    Console.WriteLine("Thks for using our calculator. Have a good day!");

                }

            }

        }
        
    }
}
