using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public static class HomeWokkChar2
    {
        public static void Exercise1() 
        {
            Console.WriteLine("Enter your name amd surname");
            string nameAndSurname = Console.ReadLine();
            Console.WriteLine($"Hello {nameAndSurname}");       
        }
        public static void Exercise2()
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sun a+b {a+b}");
        }
        public static void Exercise3()
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Dividing a+b {a / b}");
        }
        public static void Exercise4()
        {
            int result1 = -1 + 4 * 6;
            int result2 = (35 + 5) % 7;
            int result3 = 14 + -4 * 6 / 11;
            int result4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"{result1}\n{result2}\n{result3}\n{result4}\n");
        }
        public static void Exercise5()
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" a = {a}, b = {b}");
            Console.WriteLine($"After swapping");
            int c = a;
            a = b;
            b = c;
            Console.WriteLine($" a = {a}, b = {b}");

        }
        public static void Exercise6()
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c");
            int c = Convert.ToInt32(Console.ReadLine());           
            Console.WriteLine($" result of multiplication = {a*b*c}");

        }
        public static void Exercise7()
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine($"{a} + {b} = {a + b}\n{a} - {b} = {a - b}\n{a} * {b} = {a * b}\n{a} / {b} = {a / b}\n{a} mod {b} = {a % b}\n");
            }
        }
        public static void Exercise8()
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{a}*{i}={a*i}");

            }

        }
        public static void Exercise9()
        {
            Console.WriteLine("Enter a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter d");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($" The average of {a} {b} {c} {d} is {(a+b+c+d)/4}");

        }
        public static void Exercise10()
        {
            Console.WriteLine("Enter a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c");
            int c = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($" (a+b)*c = {(a+b)*c}  a*b+b*c = {(a * b) + (c*b)}");

        }

    }
}
