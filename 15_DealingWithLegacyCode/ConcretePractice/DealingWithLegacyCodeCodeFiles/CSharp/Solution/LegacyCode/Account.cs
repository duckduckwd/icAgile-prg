using System;
using System.Collections.Generic;

namespace LegacyCode
{
	public abstract class Account {

		private int accountNumber;
		private double balance;


        public int AccountNumber { get => accountNumber; set => accountNumber = value; }
        public double Balance { get => balance; private set => balance = value; }

        public virtual void WithDraw(double amount) {
			Balance -= amount;
		}
		public virtual void Deposit(double amount) {
			Balance += amount;
		}

	}
}