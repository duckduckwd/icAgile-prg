# Worked Java Example

## Task: to generate a String of six different random numbers, in format “9 – 41 – 13 – 7 – 25 – 38”

### Original version: untestable

```java
Set<Integer> numbers = new HashSet<Integer>(LOTTERY_SIZE);
while (numbers.size() < LOTTERY_SIZE) {
    numbers.add(rand.nextInt(HIGHEST_NUMBER)+1);
}
// ...
for (Integer number : numbers) {
    sb.append(number);
    if (++count < numbers.size()) sb.append(" - ");
}
```

We’re going to work with the example of simulating a lottery, because it allows us to bring out some of the core issues with mocks and stubs, without the distractions of working with an extra API.  

Our starting point is a class with a single method, `main()`.  It declares some fields,

```java
private static final int LOTTERY_SIZE = 6;
private static final int HIGHEST_NUMBER = 49;
private static Random rand = new Random();
```

The `main()` method starts by exploiting the fact that a Set rejects duplicates, as a way of ensuring the 6 lottery numbers will be distinct.  The second half of `main()` is then concerned with the correct formatting of the results.  It starts with a StringBuffer and count variable (not shown above), and builds up the string with the numbers spaced apart in the format required.

## Lottery: refactoring for testability

- Break `main()` up into more testable parts
- Method `generateRandomSet()` which returns a `Set<Integer>`
- Method `formatSet()` which takes a `Set<Integer>` & returns `String`
- Formatting logic can be tested with determinate set of `int`s

Break out number generation into method:

```java
static int generate(int limit) {
    return rand.nextInt(limit)+1;
}
```

Declare interface with this method:

```java
public interface NumberGenerator {
    public int generate(int limit);
}
```

When you take TDD to heart you will naturally be writing code in small, testable units, favouring methods which return a value (which can be tested) rather than methods whose return type is void.  Here our imagined starting point was not developed that way, and we are having to manipulate it into a more testable form.  By separating out the formatting logic we can test it with a set of numbers which the test can control, e.g.

```java
@Test
public void formatIsHyphenSeparatedSequenceOfNumbers() {
    Set<Integer> numbers = new HashSet<Integer>();

    numbers.addAll(Arrays.asList(new Integer(20), new Integer(30), new Integer(10)));

    assertTrue(Lottery.formatNumbers(numbers).matches("^\\d+ - \\d+ - \\d+$"));
}
```

---

## Lottery: manual stub

Lottery class can now use Constructor Injection:

```java
private NumberGenerator generator;
public Lottery(NumberGenerator generator) {
    this.generator = generator;
}
```

But tests need repeatability

Define a stub which provides determinacy:

```java
public class NumberGeneratorStub implements NumberGenerator {
    private int number = 0;
    public int generate(int limit) {
        return number++;
    }
}
```

The real lottery runner can inject an instance of the interface that generates real random numbers, i.e. its `main()` could look like this:

```java
Lottery lotto = new Lottery(new RandomNumberGenerator());
System.out.println(lotto.formatNumbers(lotto.generateRandomSet()));
```

The test method which uses this lotto is shown on the next slide.  We remove the dependency on something outside the control of the test, and achieve a test which has a guarantee of repeatability.

Functionality of `generateRandomSet()` can be tested:

```java
@Test
public void formatNumbersReturnsNumbersInLotteryFormat() {
    Set<Integer> numbers = lotto.generateRandomSet();
    String expected = "0 - 1 - 2 - 3 - 4 - 5";
    assertThat(lotto.formatNumbers(numbers), is(expected));
}
```

Stub can even record interactions of CUT:

- Tests can verify that CUT e.g. made expected number of calls
- Coincidentally number used for dummy data in this case is exactly that, so `verifyCallsMade()` can return it

```java
assertThat(generatorStub.verifyCallsMade(), is(6));
```

The LotteryTest class starts like this, i.e. injecting a stub instance into the lottery:

```java
private Lottery lotto;
@Before
public void setUp() {
    NumberGenerator generatorStub = new NumberGeneratorStub();
    lotto = new Lottery(generatorStub);
}
```

Incidentally, the real random number generate method can also be tested using the Hamcrest matchers.  The test serves as a constraint, and documents the fact that, that the range is strictly greater than zero but inclusive of the upper bound:

```java
@Test @SuppressWarnings("unchecked")
public void generateGivenLimit10ReturnsNumberInRange() {
    NumberGenerator generator = new RandomNumberGenerator();

    for (int i = 0; i < 10; i++) {
        assertThat(generator.generate(10), allOf(greaterThan(0), lessThanOrEqualTo(10)));
    }
}
```
