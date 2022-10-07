namespace CalculatR.Classes
{
    public class Projects
    {
        public void TimesTable()
        {
            for (int iteration = 0; iteration <= 10; iteration++)
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{iteration} x {i} = {iteration * i}");
                }
                Console.WriteLine("");
            }
        }
    }
}