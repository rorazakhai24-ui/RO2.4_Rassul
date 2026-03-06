
using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1 


            Console.WriteLine("Task 1");

            Console.WriteLine("First number");
            int number1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine($"The {number1} is greater than {number2}");

            }
            else if (number1 < number2)
            {
                Console.WriteLine($"The {number1} is less than {number2}");

            }
            else
            {
                Console.WriteLine($"The {number1} is less than {number2}");

            }

            //Task2
            Console.WriteLine("Task 2");
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 5 && num < 10)
            {
                Console.WriteLine("The number is greater than 5 and less than 10");
            }
            else
            {
                Console.WriteLine("Unknown number");
            }

            //Task3 
            Console.WriteLine("Task3");
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number == 5 ^ number == 10)

            {
                Console.WriteLine("The number is either 5 or equal to 10");

            }

            else
            {
                Console.WriteLine("Unknown number");
            }

            //Task4
            Console.WriteLine("Task4");
            Console.WriteLine("Enter a number");
            double summ = Convert.ToDouble(Console.ReadLine());

            if (summ < 100)
            {
                summ = summ * 1.05;
            }

            else if (summ >= 100 && summ <= 200)
            {
                summ = summ * 1.07;
            }

            else
            {
                summ = summ * 1.10;
            }

            Console.WriteLine("Sum with percent:");
            Console.WriteLine(summ);

            //Task5
            Console.WriteLine("Task5");
            Console.WriteLine("Enter a number");
            double sum = Convert.ToDouble(Console.ReadLine());

            if (sum < 100)
            {
                sum = sum * 1.05;
            }

            else if (sum >= 100 && sum <= 200)
            {
                sum = sum * 1.07;
            }

            else
            {
                sum = sum * 1.10;
            }
            sum = sum + 15;

            Console.WriteLine("Sum with percent and bonus:");
            Console.WriteLine(sum);

            //Task6
            Console.WriteLine("Task6");
            Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
            int operation = Convert.ToInt32(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine("Addition");
                    break;

                case 2:
                    Console.WriteLine("Subtraction");
                    break;

                case 3:
                    Console.WriteLine("Multiplication");
                    break;
                default:
                    Console.WriteLine("Opetation is Undefined");
                    break;
            }

            //Task7
            Console.WriteLine("Task 7");
            Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
            int operations = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("First number:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second number:");
            double b = Convert.ToDouble(Console.ReadLine());


            switch (operations)
            {
                case 1:
                    Console.WriteLine("Result:" + (a + b));
                    break;

                case 2:
                    Console.WriteLine("Result" + (a - b));
                    break;

                case 3:
                    Console.WriteLine("Result" + (a * b));
                    break;

                default:
                    Console.WriteLine("Undefined operations");
                    break;
            }

        }
    }
}


