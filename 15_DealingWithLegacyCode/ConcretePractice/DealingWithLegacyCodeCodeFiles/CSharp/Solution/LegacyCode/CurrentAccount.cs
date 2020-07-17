using System;
using System.Collections.Generic;

namespace LegacyCode
{
    public class CurrentAccount: Account
    {

        private List<Payee> directDebits = new List<Payee>();
        private List<Payee> standingOrders = new List<Payee>();
        private double overdraftLimit;

        public double OverdraftLimit { get => overdraftLimit; set => overdraftLimit = value; }
        public List<Payee> DirectDebits { get => directDebits; private set => directDebits = value; }
        public List<Payee> StandingOrders { get => standingOrders; private set => standingOrders = value; }


        public CurrentAccount()
        {
        }

        // used where account is current account
        public bool IsOverDrawn()
        {
            return this.Balance<0;
        }




    }
}
