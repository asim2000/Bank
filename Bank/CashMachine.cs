using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    internal class CashMachine
    {
        public static int BankNote(int amount)
        {
            if (amount >= 200) return 200;
            else if (amount >= 100) return 100;
            else if (amount >= 50) return 50;
            else if (amount >= 20) return 20;
            else if (amount >= 10) return 10;
            else if (amount >= 5) return 5;
            else return 1;
        }
    }
}
