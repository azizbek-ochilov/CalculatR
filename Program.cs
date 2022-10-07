using System;
using CalculatR.Classes;
internal class Program
{
    private static void Main(string[] args)
    {
        Security security = new Security();
        Calculator calculator = new Calculator();
        Projects project = new Projects();
        security.CheakPassword();
        calculator.AskVariables();
        calculator.SolveWithSwitch();
        calculator.SolveWithSwitchExpression();
        calculator.DisplayInequality();
        project.TimesTable();    
    }
}