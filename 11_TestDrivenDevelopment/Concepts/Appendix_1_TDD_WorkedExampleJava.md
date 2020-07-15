# Test Driven Development - Worked Example

## Task: find the highest number in an array of ints

1. Start by writing test (e.g. ArrayUtilsTest class)
   - What’s a good simple starting case?
     - Find the highest in an array with one number
   - What should we call the test method?
     - e.g. `findHighestInArrayOfOne()`
   - How do we express this test – what are we asserting?
     - `assertThat(ArrayUtils.findHighest(array), is(10))`;
   - Arrange any fixtures
     - `int[] array = {10};`

2. Make it compile (do just enough)
   - `public static int findHighest(int[] numbers) {}`
   - Generally, return 0 or null, etc. 

3. Make it fail (run test and verify red)
   - Using matchers: `Expected: is <10>    got: <0>`

4. Make it pass (do minimum to go green)
   - `return 10;`
  
5. Make it right (remove duplication)
   - Remove dependency of code on test
   - Duplication test data in solution code
   - `return numbers[0];`

At step 3 we run the test and get JUnit's Red bar.  In TDD, this constitutes success: we have completed the first essential step, writing a failing test.  
At step 4 we do the least to get the test to pass – run the test again: Green bar.  

>**Kent Beck writes:**
>"Steve Freeman pointed out that the problem with the test and code as it sits is not duplication ... The problem is the dependency between the code and the test—you can’t change one without changing the other. Our goal is to be able to write another test that “makes sense” to us, without having to change the code, something that is not possible with the current implementation.
>... If dependency is the problem, duplication is the symptom."  
>*from Test-Driven Development By Example*

At step 5 ask yourself:

- have we specified some functionality in the form of a test?
- have we satisfied what the test requires?

6. Devise next test: what’s next bit of functionality?
   - `findHighestInArrayOfTwo()`
   - Make it fail (i.e. don’t make array `{20, 10}` )
  
7. **Solution:** need to handle variable length array

```java
int highestSoFar = Integer.MIN_VALUE;
for (int i = 0; i < numbers.length; i++) {
    if (numbers[i] > highestSoFar) highestSoFar = numbers[i];
}
```

8. **‘Triangulate’** – add further tests
   - E.g. `findHighestInArbitraryArray()`
  
9. Ensure corner cases are covered.  What about `{ }` ?

What should we do about the empty array?

- Return an `int`?  Any value we could provide, e.g. `0`, or `Integer.MIN_VALUE`, would be incorrect
- Throw a checked exception?  It seems a bit extreme to make ordinary clients handle this exception if this is a rare and unusual case
- Throw a runtime exception.  Start by specifying with the annotations syntax:
  
```java
@Test(expected=RuntimeException.class)
public void findHighestInEmptyArrayThrows() {
    int [] array = {};
    ArrayUtils.findHighest(array);
}
```

Then if appropriate, refine to the more explicit format:

```java
@Test public void findHighestInEmptyArrayThrowsWithMsg() {
    int [] array = {};
    try {
        ArrayUtils.findHighest(array);
        fail("An exception should have been thrown");
    } catch (RuntimeException e) {
        assertThat(e.getMessage(), is("Empty array"));
    }
}
```
