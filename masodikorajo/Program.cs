using MySql.Data.MySqlClient;

namespace masodikorajo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem az adatbázis nevét: ");
            string ok = Console.ReadLine();
            Connect conn = new Connect(ok);
        }
    }
}
