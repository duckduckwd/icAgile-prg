# Cucumber exercise (C#)

* Work in pairs.

For this exercise you will be working in the Cucumber\Starter folder.


* At the command-line place yourself in the Cucumber\Starter folder and open the BankingCucumber.sln file

* Re-Build All
* From the View Menu bring up Test Explorer
* Run All Tests from the Test Explorer. They should pass
* Open the Features folder in the Banking.SpecFlowMsTest project and inspect the Gherkin definition
* Open the Step Definitions folder. Can you see how the two are linked?
  
## Writing your own Acceptance Criteria

Now it's your turn to write some Gherkin and associated step definitions.

Add the following Scenario to the feature file 

`Scenario: Customer withdraws cash within balance
Given the customer has a balance of 500
When the customer withdraws 200
Then the balance is 300 `

* Update the step and implementation files as required to pass the new test

* Remember to keep your repository updated!

