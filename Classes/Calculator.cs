namespace CalculatR.Classes
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }
        public void AskVariables()
        {
            Console.WriteLine("Please, enter first number:");
            FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter operation(+ - * / %)");
            Operation = Console.ReadLine();
            Console.WriteLine("Please, enter second number:");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }
        public void SolveWithSwitch()
        {
            switch (Operation)
            {
                case "+":
                    Console.WriteLine($"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber} ");
                    break;
                case "-":
                    Console.WriteLine($"{FirstNumber} - {SecondNumber} = {FirstNumber - SecondNumber} ");
                    break;
                case "*":
                    Console.WriteLine($"{FirstNumber} x {SecondNumber} = {FirstNumber * SecondNumber} ");
                    break;
                case "/":
                    Console.WriteLine($"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber} ");
                    break;
                case "%":
                    Console.WriteLine($"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber} ");
                    break;
                default:
                    Console.WriteLine(" Operation not found!");
                    break;
            }
        }
        public void SolveWithSwitchExpression()
        {
            string result = Operation switch
            {
                "+" => $"{FirstNumber} + {SecondNumber} = {FirstNumber + SecondNumber} ",
                "-" => $"{FirstNumber} - {SecondNumber} = {FirstNumber + SecondNumber} ",
                "*" => $"{FirstNumber} * {SecondNumber} = {FirstNumber * SecondNumber} ",
                "/" => $"{FirstNumber} / {SecondNumber} = {FirstNumber / SecondNumber} ",
                "%" => $"{FirstNumber} % {SecondNumber} = {FirstNumber % SecondNumber} ",
                _ => $" Operation not found!"
            };
            Console.WriteLine(result);
        }
        public void DisplayInequality()
        {
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine($"1st number is greater than 2nd number.");
            }
            else if (FirstNumber == SecondNumber)
            {
                Console.WriteLine("1st number and 2nd number are equal!");
            }
            else
            {
                Console.WriteLine($"1st number is less than 2nd number.");
            }
        }
        public void ExampleTernaryOperations()
        {
            string massage =
                FirstNumber >= 0
                    ? "1st number is positive."
                    : "1st number is negative.";
            string massage1 =
                SecondNumber >= 0
                    ? "2nd number is positive."
                    : "2nd number is negative.";
            string massage2 =
                !(FirstNumber >= 0)
                    ? "1st number is not positive."
                    : "1st number is not negative.";
            string massage3 =
                FirstNumber >= 0 && SecondNumber >= 0
                    ? "1st and 2nd numbers are positive."
                    : "There is a negative in the entered number";
            string massage4 =
                FirstNumber >= 0 || SecondNumber >= 0
                    ? "There is a positive in the entered number."
                    : "1st and 2nd numbers are negative";
                    
            Console.WriteLine(massage);
            Console.WriteLine(massage1);
            Console.WriteLine(massage2);
            Console.WriteLine(massage3);
            Console.WriteLine(massage4);
        }
        

    }
}