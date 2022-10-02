using System;
System.Console.WriteLine("Please, enter first number:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Please, enter second number:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($" 1st number is greater than 2nd number:{firstNumber>secondNumber}");
System.Console.WriteLine($" 1st number is greater than or equal to 2nd number:{firstNumber>=secondNumber}");
System.Console.WriteLine($" 1st number is less than 2nd number:{firstNumber<secondNumber}");
System.Console.WriteLine($" 2nd number is greater than or equal to 1st number:{firstNumber<=secondNumber}");
System.Console.WriteLine($" 1st and  2nd numbers are equal:{firstNumber==secondNumber}");
System.Console.WriteLine($" 1st and  2nd numbers are not equal:{firstNumber!=secondNumber}");