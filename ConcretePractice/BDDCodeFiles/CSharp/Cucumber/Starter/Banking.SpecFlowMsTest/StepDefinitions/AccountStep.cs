using System;
using TechTalk.SpecFlow;
using Banking;
using FluentAssertions;

namespace Banking.SpecFlow.MsTest
{

    [Binding]
    public class AccountStep{
	    Account acc;
	
	
	    [When(@"the customer deposits (\d+)")]
	    public void WhenTheCustomerDeposits(int amount){
		     //TODO
		    acc.Deposit(amount);
		
	    }

	    [Then(@"the balance is (\d+)")]
	    public void ThenTheBalanceIs(int amount) {

		    acc.Balance.Should().Be(amount);
				
	    }
	    [Given(@"the customer has a balance of (\d+)")]
	    public void GivenTheCustomerHasABalanceOf(int bal) {

		    acc=new Account(bal);
		    acc.Balance.Should().Be(bal);
		
	    }
	
    }
}