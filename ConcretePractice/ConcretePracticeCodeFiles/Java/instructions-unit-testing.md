# Unit testing exercise

Work in pairs.

For this exercise you will be working on Calculator project.

If you already have the calculator project in Version control, use that code.

Otherwise use the project that can be located in Unit Testing folder

Write some **unit tests** for the existing string calculator functions: *Subtract*, *Divide* and *Multiply*. 
**Note:** There is no *Add* function yet.
Write at least *five* tests. Including one that tests for *division by ZERO* with the divide function.

All tests must pass.
Do not update the functions.

Remember to keep your repository updated!

Apply Fresh/Individual and Shared Fixtures

Fixture is an object created from CUT (Class Under Test - eg: Calculator)

You may consider writing setUp() method with the following signature:

```java
@Before
public void setUp() {
    // Create test fixture object here....
}
```
