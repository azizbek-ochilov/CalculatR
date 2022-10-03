using System;
System.Console.WriteLine("Please, enter first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please, enter second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber>secondNumber)
{
    System.Console.WriteLine($"1st number is greater than 2nd number.");
}
else if (firstNumber==secondNumber)
{
    System.Console.WriteLine("1st number and 2nd number are equal!");
}
else 
{
    System.Console.WriteLine($"1st number is less than 2nd number.");
}

//ternary operations
string massage = 
    firstNumber >= 0 
        ? "1st number is positive."
        : "1st number is negative.";
string massage1 = 
    secondNumber >=0
        ? "2nd number is positive."
        : "2nd number is negative.";
System.Console.WriteLine(massage);
System.Console.WriteLine(massage1);