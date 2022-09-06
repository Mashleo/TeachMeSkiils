using System;

namespace ClassLibrary
{
    public  static class ClassWork
    {
        public static  void Exersise1()
        {
            Console.WriteLine(" works 3 time ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a");
                int firstValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b");
                int secondValue = Convert.ToInt32(Console.ReadLine());
                if (firstValue == secondValue)
                {
                    Console.WriteLine($" {(firstValue + secondValue) * 3} ");
                }
                else
                {
                    Console.WriteLine($" {firstValue + secondValue} ");
                }

            }
        }
        public static void Exersise2()
        {
            Console.WriteLine(" works 3 time ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a");
                int firstValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("b = 51");
                int secondValue = 51;
                if (firstValue > secondValue)
                {
                    Console.WriteLine("a is greater than 51 return triple the absolute difference");
                    Console.WriteLine($" {(firstValue - secondValue) * 3} ");
                }
                else
                {
                    Console.WriteLine("absolute difference between n and 51");
                    Console.WriteLine($" {  secondValue - firstValue} ");
                }

            }

        }
        public static void Exersise3()
        {
            Console.WriteLine(" works 3 time ");
            for (int i = 0; i < 3; i++)
            {
                bool res;
                Console.WriteLine("Enter a");
                int firstValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b");
                int secondValue = Convert.ToInt32(Console.ReadLine());
                if ((firstValue + secondValue) == 30)
                {
                    res = true;
                    Console.WriteLine(res);
                }
                else if (firstValue == 30 || secondValue == 30)
                {
                    res = true;
                    Console.WriteLine(res);
                }
                else
                {
                    res = false;
                    Console.WriteLine(res);
                }

            }
        }
        public static void Exersise4()
        {
            Console.WriteLine(" works 3 time ");
            for (int i = 0; i < 3; i++)
            {
                bool res;
                Console.WriteLine("Enter a");
                int firstValue = Convert.ToInt32(Console.ReadLine());

                if (firstValue <= 10)
                {
                    res = true;
                    Console.WriteLine(res);
                }
                else if (firstValue >= 100 && firstValue <= 200)
                {
                    res = true;
                    Console.WriteLine(res);
                }
                else
                {
                    res = false;
                    Console.WriteLine(res);
                }

            }
        }
        public static void Exersise10()
        {
            Console.WriteLine(" works 3 time ");
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("Enter a");
                int firstValue = Convert.ToInt32(Console.ReadLine());

                if ((firstValue % 3) == 0)
                {
                    Console.WriteLine("%3 = 0");

                }
                else if ((firstValue % 7) == 0)
                {
                    Console.WriteLine("%7 = 0");
                }
                else
                {

                    Console.WriteLine("Dont % = 0");
                }

            }
        }
        public static void ExersiseTwo1()
        {
            Console.WriteLine(" works 3 time ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a");
                int firstValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b");
                int secondValue = Convert.ToInt32(Console.ReadLine());
                if (firstValue == secondValue)
                {
                    Console.WriteLine($" {firstValue} and{ secondValue} equals ");
                }
                else
                {
                    Console.WriteLine($" {firstValue} and{ secondValue}  NOT equals ");
                }

            }
        }
        public static void ExersiseTwo2()
        {
            Console.WriteLine(" works 3 time ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a");
                int firstValue = Convert.ToInt32(Console.ReadLine());

                if (firstValue % 2 == 0)
                {
                    Console.WriteLine($" {firstValue} is even ");
                }
                else
                {
                    Console.WriteLine($" {firstValue} is odd ");
                }

            }
        }
        public static void ExersiseTwo3()
        {
            Console.WriteLine(" works 3 time ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a");
                int firstValue = Convert.ToInt32(Console.ReadLine());

                if (firstValue > 0)
                {
                    Console.WriteLine($" {firstValue} is positive ");
                }
                else if (firstValue == 0)
                {
                    Console.WriteLine($" {firstValue} is 0 ");
                }
                else
                {
                    Console.WriteLine($" {firstValue} is negative ");
                }

            }
        }
        public static void ExersiseTwo4()
        {
            Console.WriteLine(" works 3 time ");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a");
                int firstValue = Convert.ToInt32(Console.ReadLine());

                if (firstValue % 400 == 0)
                {
                    Console.WriteLine($" {firstValue} is leap year ");
                }
                else if (firstValue % 100 == 0)
                {
                    Console.WriteLine($" {firstValue} is not leap year ");
                }
                else if (firstValue % 4 == 0)
                {
                    Console.WriteLine($" {firstValue} is  leap year ");
                }


                else
                {
                    Console.WriteLine($" {firstValue} is not leap year ");
                }

            }
        }
    }
}
