# Slow Tests (Speed of Builds)

We need feedback quickly

Slow tests mean it is going to take longer to get results

What is a slow test?

Michael Feathers in his book ‘Working effectively with Legacy Code’ quotes:

>“A unit test that takes 1/10th of a second to run is a slow unit test”

---

## How do we identify slow tests?

- We need to find which tests take the most time and see how they can be optimized
- Time your tests, could be that it is the last 10% that take all the time
- Run your code through a profiler and then take note where the time is being spent

See [JUnit Extensions](./Appendix1_JUnitExtensions.md) for an example of how tests can report their own performance.

---

## How can we reduce time to test?

- Reusing data between tests
- Use a mocking framework to avoid hitting databases
- Try doing similar set up for lots of individual tests in the test fixture setup
- Run tests in parallel
- Refactor!
- Get something else to run the test for you using a continuous integration tool such as Jenkins
- Run slow tests (e.g. integration) periodically
