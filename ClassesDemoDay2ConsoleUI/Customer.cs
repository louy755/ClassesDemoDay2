using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesDemoDay2ConsoleUI
{
    public class Customer
    {
        //Properties = Member
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsApproved { get; set; }
        public CheckingAccount UserCheckingAccount { get; set; }
        public SavingAccount UserSavingAccount { get; set; }
        public CreditCardAccount UserCreditCardAccount { get; set; }


        //Default Ctor = Member
        public Customer()
        {

        }

        //Parameterized Ctor = Member
        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        // Checking account transactions
        public void Deposit(decimal amount)
        {
            UserCheckingAccount.Balance += amount;
        }
        
        public void Withdraw(decimal amount)
        {
            UserCheckingAccount.Balance -= amount;
        }
        // saving Transactuions 
        public void SavingDeposit(decimal amount)
        {
            UserSavingAccount.SavingBalance += amount;
        }

        public void SavingWithdraw(decimal amount)
        {
            UserSavingAccount.SavingBalance -= amount;
        }
        //Credit Card Transactions
        public void CreditCardDeposit(decimal amount)
        {
            UserCreditCardAccount.CreditCardBalance += amount;
        }

        public void CreditCardWithdraw(decimal amount)
        {
            UserCreditCardAccount.CreditCardBalance -= amount;
        }
    }
}
