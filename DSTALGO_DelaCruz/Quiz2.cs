//Problem encounter 1
Console.WriteLine("============================");
Console.WriteLine("No.2 Print a countdown from 5 down to 1 using a while loop.");
int count = 5;

while (count >= 1)
{
	Console.WriteLine(count);
	count--;
}
Console.WriteLine("============================");

//Problem encounter 2
Console.WriteLine("============================");
Console.WriteLine("No.2 Declare a string array containing 3 fruit names and print each element using a foreach loop.");
string[] fruits = { "Apple", "Banana", "Orange" };

foreach (string fruit in fruits)
{
	Console.WriteLine(fruit);
}
Console.WriteLine("============================");

// Problem encounter 3
Console.WriteLine("============================");
Console.WriteLine("No.2 Print numbers from 10 down to 1 using a for loop.");
for (int i = 10; i >= 1; i--)
{
	Console.WriteLine(i);
}
Console.WriteLine("============================");

// Problem encounter 4
Console.WriteLine("============================");
Console.WriteLine("No.4  Print all even numbers from 2 to 10 (inclusive) a while loop.");

int num = 2;
while (num <= 10)
{
	if (num % 2 == 0)
	{
		Console.WriteLine(num);
	}
	num++;
}
Console.WriteLine("============================");

//Problem encounter 5
Console.WriteLine("============================");
Console.WriteLine("No.5 Declare an integer array with values {10, 20 , 30 , 40, 50} and print the first and last elements.");
int[] numbers = { 10, 20, 30, 40, 50 };
Console.WriteLine("First element: " + numbers[0]);  
Console.WriteLine("Last element: " + numbers[numbers.Length - 1]);
Console.WriteLine("============================");

