using System;
namespace ClassesDemoDay2ConsoleUI
{
    public class SavingAccount
    {
        public string SavingAccNm { get; set; }
        public string savingRoutingNum { get; set; }
        public decimal SavingBalance { get; set; }
        public Customer SavingOwner { get; set; }


        public SavingAccount()
        {
        }

        public void PrintSavingBalance()
        {
            Console.WriteLine($"Your current balance is: {SavingBalance}");
        }
    }
}
