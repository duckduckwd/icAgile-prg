Feature: Bank Account Tests

#-------------------------------------------------------------
Scenario: Customer Deposits cash into account ithin limit
	
	In order to allow customers to depsoit funds into their accounts

	Given the customer has a balance of 200
		
	When the customer deposits 100 

	Then the balance is 300

#-------------------------------------------------------------
Scenario: Customer withdraws cash within balance

Given the customer has a balance of 500

When the customer withdraws 200

Then the balance is 300
