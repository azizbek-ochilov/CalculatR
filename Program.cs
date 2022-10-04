using System;
System.Console.WriteLine("Please, enter first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter operation(+ - * / %)");
string operation = Console.ReadLine();
System.Console.WriteLine("Please, enter second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());
switch(operation)
{
    case "+":
        System.Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber} ");
        break;
    case "-":
        System.Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber-secondNumber} ");
        break;
    case "*":
        System.Console.WriteLine($"{firstNumber} x {secondNumber} = {firstNumber*secondNumber} ");
        break;
    case "/":
        System.Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber/secondNumber} ");
        break;
    case "%":
        System.Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber%secondNumber} ");
        break;

}

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
string massage2 = 
    !(firstNumber >= 0) 
        ? "1st number is not positive."
        : "1st number is not negative.";
string massage3 = 
    firstNumber >= 0 && secondNumber>=0 
        ? "1st and 2nd numbers are positive."
        : "There is a negative in the entered number";
string massage4 = 
    firstNumber >= 0 || secondNumber>=0
        ? "There is a positive in the entered number."
        : "1st and 2nd numbers are negative";


System.Console.WriteLine(massage);
System.Console.WriteLine(massage1);
System.Console.WriteLine(massage2);
System.Console.WriteLine(massage3);
System.Console.WriteLine(massage4);