﻿using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OperatorExamples();
            TryAnIf();
            TrySomeLoops();
            TryAnIfElse();
        }

        private static void TryAnIf()
        {
            int someValue = 4;
            string name = "Bobbo Jr.";
            if ((someValue == 3) && (name == "Joe"))
            {
                Console.WriteLine("x is 3 and the name is Joe");
            }
            Console.WriteLine("This line runs no matter what");
        }
        /* Runs 3rd
         * for some stupid reason */
        private static void TryAnIfElse()
        {
            int x = 5;
            if (x == 10)
            {
                Console.WriteLine("x must be 10");
            }
            else
            {
                Console.WriteLine("x isn't 10");
            }
        }
        // Runs second
        private static void TrySomeLoops()
        {
            int count = 0;

            while (count < 10)
            {
                count++;
            }
            for (int i = 0; i < 5; i++)
            {
                count--;
            }
            Console.WriteLine("The answer is " + count);
        }

        private static void OperatorExamples()
        {
            int width = 3;
            
            width++;
            
            int height = 2 + 4;
            int area = width * height;
            Console.WriteLine(area);

            while (area < 20)
            {
                height++;
                area = width * height;
            }

            do
            {
                width--;
                area = width * height;
            } while (area > 25);

            string result = "The area";
            result = result + " is " + area;
            Console.WriteLine(result);

            bool truthValue = true;
            Console.WriteLine(truthValue);

        }
    }
}
