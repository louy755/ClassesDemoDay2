using System;
namespace ClassesDemoDay2ConsoleUI
{
    public class CreditCardAccount
    {
        public string CreditCardAccNm { get; set; }
        public string CreditCardRoutingNm { get; set; }
        public decimal CreditCardBalance { get; set; }
        public Customer CreditCardOwner { get; set; }

        public CreditCardAccount()
        {
        }

        public void PrintCreditBalance()
        {
            Console.WriteLine($"Your current balance is: {CreditCardBalance}");
        }
    }
}
