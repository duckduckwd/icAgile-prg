# Test Driven Development Concrete Practice (Java)

* Work in pairs.

For this exercise you will be working on Calculator.

If you already have the calculator project in your repo, continue with this otherwise copy the Starter folder from the java bundle and start from there.

You will be developing the add function following TDD by writing a series of tests.

Consider alternating roles between tests.

Eg: One person codes the test, then the other person writes just enough code to pass

Ensure you only write enough production code to pass the failing test(s)

## To Do:

The required tests are :

1. Empty String returns ZERO
`int iResult = calc.add("");` should return `0`

2. Single number returns the value
`int iResult = calc.add("10");` should return `10`

3. Two numbers separated by comma returns the sum
`int iResult = calc.add("5,3");` should return `8`

4. Two numbers separated by new line returns the sum
`int iResult = calc.add("6\n4");` should return `10`

5. Three numbers separated by either comma or new line returns the sum
`int iResult = calc.add("3,4,2");` or
`int iResult = calc.add("3\n4\n2");` or
`int iResult = calc.add("3,4\n2");` should return `9`

6. Negative numbers should throw an exception
`int iResult = calc.add("4,-9");` should **throw an exception**

All tests must pass.
