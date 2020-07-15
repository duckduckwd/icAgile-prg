# Unit testing exercise

Work in pairs.

For this exercise you will be working on Calculator project.

If you already have the calculator project in version control, use that code.

Otherwise use the project that can be located in the Starter folder - copy this and add it to your repo.

Write some **unit tests** for the existing string calculator functions: *Subtract*, *Divide* and *Multiply*.
**Note:** There is no *Add* function yet.
Write at least *five* tests. Including one that tests for *division by ZERO* with the divide function.

All tests must pass.
Do not update the functions.

Remember to keep your repository updated!

Apply Fresh/Individual and Shared Fixtures

Fixture is an object created from CUT (Class Under Test - eg: Calculator)

You may consider calling the `beforeEach()` method to set up the test fixture:

```javascript
beforeEach(() => {
  // Create test fixture object here...
});
```
