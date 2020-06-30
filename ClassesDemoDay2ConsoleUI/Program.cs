using System;

namespace ClassesDemoDay2ConsoleUI
{
    class Program
    {
        static void Main(string[] args)

        {
            //Instanciating a customer = Creating an variable of the Customer data type
            Customer customer1 = new Customer();

            //Getting user input
            Console.WriteLine("Please give me your first name");
            customer1.FirstName = Console.ReadLine();

            Console.WriteLine("Please give me your last name");
            customer1.LastName = Console.ReadLine();

            //Printing customer info
            Console.Write($"Hello {customer1.FirstName} {customer1.LastName}");
            Console.WriteLine();

            Console.WriteLine("Please enter your age!");
            customer1.Age = int.Parse(Console.ReadLine());

            if (customer1.Age > 18)
            {
                Console.WriteLine("Please choose  a number " +
                    "\n" +
                    "1- Checking Account\n" +
                    "2- Saving Account\n" +
                    "3- CreditCard Account");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        //Instanciating a Checking Account
                        CheckingAccount checkingAccount = new CheckingAccount();

                        //Setting properties for the Checking Account
                        checkingAccount.RoutingNumber = "CHA400457";
                        checkingAccount.AccountNumber = "CHA541344";
                        checkingAccount.Balance = 50;

                        //***** Setting the Owner property to the instance of the customer we created *****//
                        checkingAccount.Owner = customer1;

                        //***** Setting the CheckingAccount property on the customer class *****//
                        customer1.UserCheckingAccount = checkingAccount;

                        //Printing the values of the Account
                        Console.WriteLine($"Your checking account number is: {checkingAccount.AccountNumber}");
                        Console.WriteLine($"The owner of the account is: {checkingAccount.Owner.FirstName} {checkingAccount.Owner.LastName}");
                        Console.WriteLine($"Thank you for creting new checking account you have $ {checkingAccount.Balance}!!");

                        //Asking user to deposit or withdraw
                        Console.WriteLine("Do you want to deposit or withdraw money?\n" +
                            "1- Depost\n" +
                            "2- Withdraw");
                        int userResponse = int.Parse(Console.ReadLine());
                        
                        decimal amount;
                        switch (userResponse)
                        {
                            case 1:
                                //Deposit operations
                                Console.WriteLine("How much?");
                                amount = decimal.Parse(Console.ReadLine());
                                customer1.Deposit(amount);
                                customer1.UserCheckingAccount.PrintBalance();
                                break;
                            case 2:
                                //Withdraw operations
                                Console.WriteLine("How much?");
                                amount = decimal.Parse(Console.ReadLine());
                                customer1.Withdraw(amount);
                                customer1.UserCheckingAccount.PrintBalance();
                                break;
                        }

                        break;
                     case 2:
                        //Instanciating a Saving Account
                        SavingAccount savingAccount = new SavingAccount();

                        //Setting properties for the Saving Account
                        savingAccount.SavingAccNm = "SA4567435";
                        savingAccount.savingRoutingNum = "SA2541234";
                        savingAccount.SavingBalance = 50;

                        //***** Setting the Owner property to the instance of the customer we created *****//
                        savingAccount.SavingOwner = customer1;

                        //***** Setting the SavingAccount property on the customer class *****//
                        customer1.UserSavingAccount = savingAccount;

                        //Printing the values of the Account
                        Console.WriteLine($"Your Saving account number is: {savingAccount.SavingAccNm}");
                        Console.WriteLine($"The owner of the account is: {savingAccount.SavingOwner.FirstName} {savingAccount.SavingOwner.LastName}");
                        Console.WriteLine($"Thank you to open the Saving account you rewarded ${savingAccount.SavingBalance}");

                        //Asking user to deposit or withdraw from his saving account
                        Console.WriteLine("Saving Account Do you want to deposit or withdraw money?\n" +
                            "1- Depost\n" +
                            "2- Withdraw");
                        int userRes = int.Parse(Console.ReadLine());

                        decimal amnt;
                        switch (userRes)
                        {
                            case 1:
                                //Deposit operations
                                Console.WriteLine("How much Money to Deposit?");
                                amnt = decimal.Parse(Console.ReadLine());
                                customer1.SavingDeposit(amnt);
                                customer1.UserSavingAccount.PrintSavingBalance();
                                break;
                            case 2:
                                //Withdraw operations
                                Console.WriteLine("How much Money to Withdraw?");
                                amnt = decimal.Parse(Console.ReadLine());
                                customer1.SavingWithdraw(amnt);
                                customer1.UserSavingAccount.PrintSavingBalance();
                                break;
                        }
                      
                        break;
                    case 3:
                        //Instanciating a CreditCard Account
                        CreditCardAccount creditCardAccount = new CreditCardAccount();

                        //Setting properties for the CreditCard Account
                        creditCardAccount.CreditCardAccNm = "CR345674";
                        creditCardAccount.CreditCardRoutingNm = "CR25234";
                        creditCardAccount.CreditCardBalance = 50;

                        //***** Setting the Owner property to the instance of the customer we created *****//
                        creditCardAccount.CreditCardOwner = customer1;

                        //***** Setting the CreditCard Account property on the customer class *****//
                        customer1.UserCreditCardAccount = creditCardAccount;

                        //Printing the values of the Account
                        Console.WriteLine($"Your CreditCard account number is: {creditCardAccount.CreditCardAccNm}");
                        Console.WriteLine($"The owner of the account is: {creditCardAccount.CreditCardOwner.FirstName} {creditCardAccount.CreditCardOwner.LastName}");
                        Console.WriteLine($"Thank you to open the CreditCard account, you rewarded ${creditCardAccount.CreditCardBalance}");

                        //Asking user to deposit or withdraw from his saving account
                        Console.WriteLine("CreditCard Account Do you want to deposit or withdraw money?\n" +
                            "1- Pay CreditCard\n" +
                            "2- Withdraw");
                        int userResp = int.Parse(Console.ReadLine());

                        decimal amt;
                        switch (userResp)
                        {
                            case 1:
                                //Pay CreditCard operations
                                Console.WriteLine("How much Money to pay off today?");
                                amt = decimal.Parse(Console.ReadLine());
                                customer1.CreditCardDeposit(amt);
                                customer1.UserCreditCardAccount.PrintCreditBalance();
                                break;
                            case 2:
                                //Withdraw operations
                                Console.WriteLine("How much Money to Withdraw?");
                                amt = decimal.Parse(Console.ReadLine());
                                customer1.CreditCardWithdraw(amt);
                                customer1.UserCreditCardAccount.PrintCreditBalance();
                                break;
                        }
                        
                        break;
                    default:
                        Console.WriteLine("Invalid Entery please try again later");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You're too young to have a bank account!");
                return;
            }

        }
    }
}
