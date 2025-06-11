using System;

void CalculateNumbers(int var1, int var2)
{
    int sum = var1 + var2;
    int difference = var1 - var2;
    int product = var1 * var2;
    double quotient = (double)var1 / var2;

    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Difference: {difference}");
    Console.WriteLine($"Product: {product}");
    Console.WriteLine($"Quotient: {quotient}");
}
void Main()
{
    Console.WriteLine("Enter first number:");
    int number1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter second number:");
    int number2 = Convert.ToInt32(Console.ReadLine());

    CalculateNumbers(number1, number2);
}
Main();
// This program prompts the user to enter two numbers and then calculates and displays their sum, difference, product, and quotient.
// It uses a method to perform the calculations and prints the results to the console.
// The program is structured to be simple and straightforward, focusing on basic arithmetic operations.
// The CalculateNumbers method takes two integers as parameters and performs the calculations.
// The Main method handles user input and calls the CalculateNumbers method with the provided numbers.
// The program is designed to be easy to understand and modify, making it suitable for educational purposes or simple arithmetic tasks.
// The program does not include error handling for invalid inputs, which could be added for robustness.
// The program is written in C# and can be run in any C# compatible environment.
// The program is structured to be simple and straightforward, focusing on basic arithmetic operations.
// The CalculateNumbers method takes two integers as parameters and performs the calculations.
// The Main method handles user input and calls the CalculateNumbers method with the provided numbers.
// The program is designed to be easy to understand and modify, making it suitable for educational purposes or simple arithmetic tasks.
// The program does not include error handling for invalid inputs, which could be added for robustness. 