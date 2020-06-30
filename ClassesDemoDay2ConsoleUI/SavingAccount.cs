using System;
namespace ClassesDemoDay2ConsoleUI
{
    public class SavingAccount
    {
        public string SavingAccNm { get; set; }
        public string savingRoutingNum { get; set; }
        public Customer SavingOwner { get; set; }

        //Properties
        private decimal _savingBalance;

        public decimal SavingBalance
        {
            get { return _savingBalance; }

            set
            {
                Console.WriteLine("Please enter your pin number");
                string pin = Console.ReadLine();
                if (pin == "1234")
                {
                    _savingBalance = value;
                }
                else
                {
                    Console.WriteLine("Invalid user");
                    return;
                }
            }
        }


        public SavingAccount()
        {
        }

        public void PrintSavingBalance()
        {
            Console.WriteLine($"Your current balance is: {SavingBalance}");
        }
    }
}
