using System;

namespace TestingCSharp
{
    public class Account
    
    { private decimal balance;
        private string firstName;
        private string lastName;
        private int pin;

        public decimal Balance
        {
            get => balance;
            set => balance = value;
        }

        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }

        public string LastName
        {
            get => lastName;
            set => lastName = value;
        }

        public int Pin
        {
            get => pin;
            set => pin = value;
        }

       

        public void DepositCash(decimal amount)
        {
            balance += amount;
        }

        public void WithdrawCash(decimal amount, int pin)
        {
            if (pin == this.pin)
            {
                if (amount < balance)
                {
                    balance -= amount;

                }
                else
                {
                    System.Console.WriteLine("Insufficient funds");
                }
                
            }
            else
            {
                System.Console.WriteLine("invalid pin");
            }
        }
    }
}