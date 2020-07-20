# TDD Exercise

* Work in pairs.
* For this exercise you will be working on Calculator project in the TDD\Starter folder

* You will be developing the Add function following TDD by writing a series of tests.

* Consider alternating roles between tests.
Eg: One person codes the test, then the other person writes just enough code to pass

* Ensure you only write enough production code to pass the failing test(s)

The required tests are :

1. Empty String returns ZERO:
`int iResult = calc.Add(“”);`
Should return 0

2. Single number returns the value:
`int iResult = calc.Add("10”);`
Should return 10

3. Two numbers separated by comma returns the sum:
`int iResult = calc.Add(“5,3”);`
Should return 8

4. Two numbers separated by new line returns the sum:
`int iResult = calc.Add("6\n4");`
Should return 10

5. Three numbers separated by either comma or new line returns the sum:
`int iResult = calc.Add("3,4,2");`
Or
`int iResult = calc.Add("3\n4\n2");`
Or
`int iResult = calc.Add("3,4\n2");`
Should return 9

6. Negative numbers should throw an exception
`int iResult = calc.Add("4,-9");`
Should throw an exception

All tests must pass.