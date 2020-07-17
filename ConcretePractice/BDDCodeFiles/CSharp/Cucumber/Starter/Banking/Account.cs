using System;

namespace Banking
{
    public class Account {
	
	    private int balance;
	
	    public Account(int balance)
	    {
		    this.balance=balance;
	    }
	
	    public void Deposit(int amount)
	    {
		    this.balance+=amount;
	    }

	    public int Balance
	    {
            get => this.balance;
	    }

    }
}