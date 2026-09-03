using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("======================================");
        Console.WriteLine("No.1 Student Information");
        Console.WriteLine("Enter Your Name.");
        string uName = Console.ReadLine();
        Console.WriteLine("Enter Your Course.");
        string uCourse = Console.ReadLine();
        Console.WriteLine("Enter Your Year-Level.");
        string uYear = Console.ReadLine();
        Console.WriteLine("Enter Your Section.");
        string uSection = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Name is: " + uName);
        Console.WriteLine("Course is: " + uCourse);
        Console.WriteLine("Year-Level is: " + uYear);
        Console.WriteLine("Section is: " + uSection);
        Console.WriteLine(""); 


        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("No.2 Basic Calculator");
        Console.WriteLine("Enter X: ");
        int X = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Y: ");
        int Y = Convert.ToInt32(Console.ReadLine());
        int sum = X + Y;
        Console.WriteLine("The sum of the X & Y is: " + sum);
        int difference = X - Y;
        Console.WriteLine("The difference of X & Y is: " + difference);
        int multiply = X * Y;
        Console.WriteLine("The result of multiplying of X & Y is: " + multiply);
        int divisionresult = X / Y;
        Console.WriteLine("The division result of X & Y is: " + divisionresult);
        Console.WriteLine("");


        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("No.3 Area of a Rectangle");
        Console.Write("Enter Length: ");
        int length = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Width: ");
        int width = Convert.ToInt32(Console.ReadLine());
        int area = length * width;
        Console.WriteLine("Equal to " + area);
        Console.WriteLine("");


        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("No.4 Student Grade");
        Console.Write("Prelim: ");
        double grade1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Midterm : ");
        double grade2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Final: ");
        double grade3 = Convert.ToInt32(Console.ReadLine());
        double average = (grade1 + grade2 + grade3) / 3;
        Console.WriteLine("The average grade is: " + average);
        Console.WriteLine("");


        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("No.5 Boolean Input");
        Console.Write("Are you a student? (true/false): ");
        bool isStudent = Convert.ToBoolean(Console.ReadLine());
        Console.WriteLine("Student status: " + isStudent);


        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("No.6 Age Verification");
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        bool isAdult = age >= 18;
        Console.WriteLine("Is 18 or older: " + isAdult);
        Console.WriteLine("");


        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("No.7 Fullname");
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();
        string fullName = firstName + " " + lastName;
        Console.WriteLine("Full Name: " + fullName);
        Console.WriteLine("");


        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("No.8 Shopping Calculator");
        Console.Write("Product Name: ");
        string productName = Console.ReadLine();
        Console.Write("Enter price: ");
        double price = double.Parse(Console.ReadLine());
        Console.Write("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        double total = price * quantity;
        Console.WriteLine("Receipt");
        Console.WriteLine("Product: " + productName);
        Console.WriteLine("Total: " + total.ToString("C"));
        Console.WriteLine("");


        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("No.9 Salary Calculator");
        Console.Write("Enter employee name: ");
        string empName = Console.ReadLine();
        Console.Write("Enter hours worked: ");
        double hoursWorked = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter hourly rate: ");
        double hourlyRate = Convert.ToDouble(Console.ReadLine());
        double salary = hoursWorked * hourlyRate;
        Console.WriteLine("Employee: " + empName);
        Console.WriteLine("Salary: " + salary);
        Console.WriteLine("");

        
        Console.WriteLine("======================================");
        Console.WriteLine("");
        Console.WriteLine("No.10 Mini Student Information System");
        Console.Write("Enter Name: ");
        string studentName = Console.ReadLine();
        Console.Write("Enter Course: ");
        string studentCourse = Console.ReadLine();
        Console.Write("Enter Age: ");
        int studentAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Year Level: ");
        string studentYear = Console.ReadLine();
        Console.Write("Enter Grade 1: ");
        double sGrade1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Grade 2: ");
        double sGrade2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Grade 3: ");
        double sGrade3 = Convert.ToDouble(Console.ReadLine());
        double studentAverage = (sGrade1 + sGrade2 + sGrade3) / 3;
        bool studentIsAdult = studentAge >= 18;
        
        Console.WriteLine("");
        Console.WriteLine("Student Information");
        Console.WriteLine("Name: " + studentName);
        Console.WriteLine("Course: " + studentCourse);
        Console.WriteLine("Age: " + studentAge);
        Console.WriteLine("Year Level: " + studentYear);
        Console.WriteLine("Average Grade: " + studentAverage);
        Console.WriteLine("Is 18 or older: " + studentIsAdult);
        Console.WriteLine("");
        Console.WriteLine("======================================");
    }
}
