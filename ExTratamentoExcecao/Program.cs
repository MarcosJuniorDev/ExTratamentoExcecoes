using ExTratamentoExcecao.Entities;
using ExTratamentoExcecao.Entities.Exceptions;
using System.Globalization;

namespace ExTratamentoExcecao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double inititalBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Account account = new Account(number, holder, inititalBalance, withdrawLimit);

            Console.WriteLine();

            Console.Write("Enter amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                account.Withdraw(withdraw);
                Console.WriteLine($"New Balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            catch (AccountException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
        }
    }
}