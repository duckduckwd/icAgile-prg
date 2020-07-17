using System;
namespace LegacyCode
{
    public class SavingsAccount: Account
    {
        private double interest;
        public double Interest { get => interest; set => interest = value; }

        public SavingsAccount()
        {
        }
        public void AddInterestToAccount()
        { // used where account is a deposit acct
            Deposit(Balance * Interest);
        }


    }
}
