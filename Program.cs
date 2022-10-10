using System;
using CalculatR.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Security security = new Security();
            Calculator calculator = new Calculator();
            Projects project = new Projects();
            System.Console.WriteLine("Program was created at :"+ DateTimeOffset.UtcNow);
            security.CheakPassword();
            calculator.AskVariables();
            calculator.SolveWithSwitch();
            calculator.SolveWithSwitchExpression();
            calculator.DisplayInequality();
            project.TimesTable();
        }
        catch(FormatException formatException)
        {
            System.Console.WriteLine($" Error detected: {formatException.Message}");
        }
        catch (Exception exception)
        {
            System.Console.WriteLine("Error was detected but type is unknown!"+ exception);
        }
        System.Console.WriteLine("Program ended...");
            
    }
}