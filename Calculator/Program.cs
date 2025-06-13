using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Calculator!");
                Console.WriteLine("Enter the first numbers:");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the second numbers:");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Choose an operation: +, -, *, /");
                string operation = Console.ReadLine();
                double result = 0;
                /*  if(operation == "+")
                {
                    result = num1 + num2;
                }
                else if (operation == "-")
                {
                    result = num1 - num2;
                }
                else if (operation == "*")
                {
                    result = num1 * num2;
                }
                else if (operation == "/")
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        continue; // Skip to the next iteration
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operation.");
                    continue; // Skip to the next iteration
                }*/
                /*  switch (operation)
                  {
                      case "+":
                          result = num1 + num2;
                          break;
                      case "-":
                          result = num1 - num2;
                          break;
                      case "*":
                          result = num1 * num2;
                          break;
                      case "/":
                          if (num2 != 0)
                              result = num1 / num2;
                          else
                              Console.WriteLine("Error: Division by zero is not allowed.");
                          return; // Exit if division by zero
                      default:
                          Console.WriteLine("Invalid operation.");
                          return; // Exit if invalid operation
                  }*/
                Console.WriteLine($"The result of {num1} {operation} {num2} is: {result}");
                Console.WriteLine("Do you want to perform another calculation? (y/n)");
                string answer = Console.ReadLine();
                if (!answer.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

            }
        }
    }
}
