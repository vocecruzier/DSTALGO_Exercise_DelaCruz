using System;
class Program
    {
        static void Main(string[] args) {

// No.1 Display 5 inputs anything, name age, prof said
Console.WriteLine("Question no.1 ");
Console.WriteLine("================================");
Console.WriteLine("Enter your name:");
string name = Console.ReadLine(); 
Console.WriteLine("Enter your age:");
string age = Console.ReadLine();
Console.WriteLine("Enter your favorite color:");
string color = Console.ReadLine();
Console.WriteLine("Enter your favorite food:");
string food = Console.ReadLine();
Console.WriteLine("Enter your favorite hobby:");
string hobby = Console.ReadLine();
Console.WriteLine("================================");

/*No. 2 Three-Numbwer Mathematical Challenege, I got number 5 (the paper).
Input three numbers. Calculate the sum, average, product, larget, smallest, range. Then use logical operators to determine:, All numbers are positive, At least one number is zero, and all numbers are equal. */

Console.WriteLine("Question no.2");
Console.WriteLine("================================");
// Input three numbers
Console.WriteLine("Enter the first number:");
string input1 = Console.ReadLine();
Console.WriteLine("Enter the second number:");
string input2 = Console.ReadLine();
Console.WriteLine("Enter the third number:");
string input3 = Console.ReadLine();

// Calculate the sum, average, product, largest, smallest, and range???
int num1 = int.Parse(input1);
int num2 = int.Parse(input2);
int num3 = int.Parse(input3);
int sum = num1 + num2 + num3;
double average = sum / 3.0;
int product = num1 * num2 * num3;
int largest = Math.Max(Math.Max(num1, num2), num3);
int smallest = Math.Min(Math.Min(num1, num2), num3);
int range = largest - smallest;

// Then use logical operators to determine, All numbers are positive, At least one number is zero, and all numbers are equal.
bool allPositive = num1 > 0 && num2 > 0 && num3 > 0;
bool atLeastOneZero = num1 == 0 || num2 == 0 || num3 == 0;
bool allEqual = num1 == num2 && num2 == num3;

// Display them results lez go
Console.WriteLine("Sum: " + sum); 
Console.WriteLine("Average: " + average);
Console.WriteLine("Product: " + product);
Console.WriteLine("Largest: " + largest);
Console.WriteLine("Smallest: " + smallest);
Console.WriteLine("Range: " + range);
Console.WriteLine("All numbers are positive: " + allPositive);
Console.WriteLine("At least one number is zero: " + atLeastOneZero);
Console.WriteLine("All numbers are equal: " + allEqual);
Console.WriteLine("================================");

        }
    }
