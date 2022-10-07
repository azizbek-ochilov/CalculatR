namespace CalculatR.Classes
{
    public class Security
    {
        public void CheakPassword()
        {
            string password = "";
            do 
            {
            System.Console.WriteLine("Enter password:");
            password = Console.ReadLine();
            }while(password != "pa$$w0rd");
        }
    }
}