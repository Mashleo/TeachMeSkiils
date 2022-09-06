using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public static class HomeWokrChar9
    {
        public static void PrintWelcome()
        {
            Console.WriteLine("Welcome Friends!");
        }
        public static void PrintHaveANiceDay()
        {
            Console.WriteLine("Have a nice day");
        }

        public static string EnterName()
        {
            Console.Write("Enter name ");
            string name = Console.ReadLine();
            return name;
        }
        public static void WelcomePlusName(string name)
        {
            Console.WriteLine($"Welcome friend {name}");
        }
        public static int EnterFirstValue()
        {
            Console.Write("Enter first value - ");
            int firstValue = Convert.ToInt32(Console.ReadLine());
            return firstValue;
        }
        public static int EnterSecondValue()
        {
            Console.Write("Enter first value - ");
            int secondValue = Convert.ToInt32(Console.ReadLine());
            return secondValue;
        }
        public static void Sum(int a, int b)
        {
            Console.WriteLine($"The sum of two numbers is {a + b}");
        }
        public static string EnterString()
        {
            Console.WriteLine("Enter test string");
            string testString = Console.ReadLine();
            return testString;
        }
        public static void NumberOfSpacesInTheString(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    count++;
                }

            }
            Console.WriteLine($" In {str} contains {count} spaces ");
        }
        public static int[] EnterElementsOfArray()
        {
            Console.WriteLine("Enter number of element");
            int numberOfelement = Convert.ToInt32(Console.ReadLine());
            int[] ourArray = new int[numberOfelement];
            for (int i = 0; i < numberOfelement; i++)
            {
                Console.Write($"Enter {i} element -"  );
                ourArray[i] = Convert.ToInt32(Console.ReadLine());

            }
            return ourArray;
            
        }
        public static void SumOfElementArray(int[] arr)
        {
            int cont = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                cont += arr[i];

                }
            Console.WriteLine($"The sum of the elements of the array is {cont}");
            
        }
        public static void SwapTwoInt(int a, int b)
        {
            Console.WriteLine($"Before {a} and {b}");
            int storage = a;
            a = b;
            b = storage;
            Console.WriteLine($"After {a} and {b}");


        }
        public static void RasingIntegerNumberToAnother(int a, int b)
        {
           
           Console.WriteLine($" Result of raising an {a} to {b} - {Math.Pow(a,b)}");


        }
        public static void FibonachiNumber()
        {
            Console.Write("Input number of Fibonacci Series :");
            int numberOfelement = Convert.ToInt32(Console.ReadLine());
            int firstNumerFibonacci = 0;
            int secondNumerFibonacci = 1;
            int storage;
            for (int i = 0; i < numberOfelement; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine(firstNumerFibonacci);
                }
                else if (i == 1)
                {
                    Console.WriteLine(secondNumerFibonacci);
                }
                else
                {
                    storage = secondNumerFibonacci;
                    secondNumerFibonacci =firstNumerFibonacci + secondNumerFibonacci;
                    Console.WriteLine(secondNumerFibonacci);
                    firstNumerFibonacci = storage;
                    

                }
                
                
             }


        }
        public static void CheckPrime(int a)
        {
            bool res = true;
            for (int i = 2; i < a; i++)
            {
                if (a%i==0)
                {
                    Console.WriteLine($"{a} is not prime number");
                    res = false;
                    break;
                   
                    
                }
            }
            if (res)
            {
                Console.WriteLine($"{a} is prime number");

            }
           
           
        }
        public static void SumIndividualDigits(string strin)
        {
            
            int sum = 0;
            for (int i = 0; i < strin.Length; i++)
            {
               
                
                
               sum += Convert.ToInt32(strin[i]);
                

            }
            Console.WriteLine($"The sum of the digits of the number {strin} is : {sum}");
            

        }

    }
}
