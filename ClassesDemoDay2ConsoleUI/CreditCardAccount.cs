using System;
namespace ClassesDemoDay2ConsoleUI
{
    public class CreditCardAccount
    {
        public string CreditCardAccNm { get; set; }
        public string CreditCardRoutingNm { get; set; }
        public Customer CreditCardOwner { get; set; }

        //Properties
        private decimal _creditCardBalance;

        public decimal CreditCardBalance
        {
            get { return _creditCardBalance; }

            set
            {
                Console.WriteLine("Please enter your pin number");
                string pin = Console.ReadLine();
                if (pin == "1234")
                {
                    _creditCardBalance = value;
                }
                else
                {
                    Console.WriteLine("Invalid user");
                    return;
                }
            }
        }

        public CreditCardAccount()
        {
        }

        public void PrintCreditBalance()
        {
            Console.WriteLine($"Your current balance is: {CreditCardBalance}");
        }
    }
}
