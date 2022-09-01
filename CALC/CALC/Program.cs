using System;

namespace CALC
{
   
        class Program
        {
            static void Main(string[] args)
            {

                Consle();
                SwitchAndCase(FirstValue(), SecondValue(), Operation());

            }
        //static bool AnsverForRepeat() {
           
        //    Console.WriteLine("**Do your want again?**");
        //    Console.WriteLine("**If YES enter - true **");
        //    Console.WriteLine("**If NO enter - false **");

        //    bool res = Convert.ToBoolean(Console.ReadLine());
            
        //    return res;
        //}
           


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
                      
                        default:
                            Console.WriteLine("Wrong operation");
                            break;
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
