using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Consle();
           // SwitchAndCase(FirstValue(), SecondValue(), Operation());

        }
        static void Repeat()
        {
            int repeat = 1;
            while (repeat == 1)
            {
                Console.WriteLine("**Do your want again?**");
                Console.WriteLine("**If YES enter - 1 **");
                Console.WriteLine("**If NO enter any number (only number!) **");
                
                repeat = Convert.ToInt32(Console.ReadLine());
                SwitchAndCase(FirstValue(), SecondValue(), Operation());
            }
        }


        static double FirstValue()
        {
            Console.Write("**Enter first value =");
            double firstValue = Convert.ToDouble(Console.ReadLine());
            return firstValue;
        }
        static double SecondValue()
        {
            Console.Write("**Enter second value =");
            double secondValue = Convert.ToDouble(Console.ReadLine());
            return secondValue;
        }
        static string Operation()
        {
            Console.Write("*Сhoose an operation-");
            string operation = Console.ReadLine();
            return operation;
        }
        static void Consle()
        {
            Console.Clear();
            Console.WriteLine("**My First Calculator**");
            Console.WriteLine("*He can +,-,/**");



        }
        static void SwitchAndCase(double firstValue, double secondValue, string operation)
        {

            int repeat = 1;
            while (repeat == 1)
            {

                switch (operation)
                {
                    case "+":
                        Plus(firstValue, secondValue);
                        break;
                    case "-":
                        Minus(firstValue, secondValue);

                        break;
                    case "/":
                        Division(firstValue, secondValue);
                        break;
                    case "*":
                        Multiplication(firstValue, secondValue);
                        break;
                    //case "%":
                    //    result = firstValue % secondValue;
                    //    Console.WriteLine($"Your result {result}");
                    //    break;
                    //case "sqrt":
                    //    firstValue = Math.Sqrt(firstValue);
                    //    secondValue = Math.Sqrt(secondValue);
                    //    Console.WriteLine($"Your result {firstValue} and {secondValue}");
                    //    break;
                    default:
                        Console.WriteLine("Wrong operation");
                        break;
                }




            }
            static void Plus(double a, double b)
            {

                Console.WriteLine($"Your result {a + b}");

            }
            static void Minus(double a, double b)
            {
                Console.WriteLine($"Your result {a - b}");
            }
            static void Multiplication(double a, double b)
            {

                Console.WriteLine($"Your result {a * b}");

            }
            static void Division(double a, double b)
            {
                Console.WriteLine($"Your result {a / b}");
            }

        }
    }
}
