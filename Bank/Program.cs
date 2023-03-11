using System;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            while (amount > 0)
            {
                int result = CashMachine.BankNote(amount);
                Console.WriteLine(result);
                amount -= result;
            }
        }
    }
}
