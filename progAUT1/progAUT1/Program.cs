namespace progAUT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new (string username, string password)[]
             {
                 ("vasile", "parola1"),
                 ("gheorghe", "parola2"),
                 ("mircea", "parola3")
             };
            bool Logged = false;

            do
            {
                Console.WriteLine("introdu user ");
                string inputUsername = Console.ReadLine();
                Console.WriteLine("introdu parola ");
                string inputPassword = Console.ReadLine();

                foreach (var user in users)
                {
                    if (inputUsername == user.username && inputPassword == user.password)
                    {
                        Logged = true;
                        Console.WriteLine($"Bine ai venit, {inputUsername}!");
                        break;
                    }
                }

                if (!Logged)
                {
                    Console.WriteLine("Nume sau parola gresita");
                }
            } while (!Logged);
        }
    }
}