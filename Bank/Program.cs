using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter amount");
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount <= 0) throw new Exception("Amount must be greater than 0");
                while (amount > 0)
                {
                    int result = CashMachine.BankNote(amount);
                    Console.WriteLine(result);
                    amount -= result;
                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
