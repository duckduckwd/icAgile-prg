# Slow Tests (Speed of Builds) - Appendix 1 - JUnit Extensions

## Performance tests

- Beware non-deterministic

```java
long start = System.currentTimeMillis();
long expected = 3000L;
… (perform test)
long time = System.currentTimeMillis() - start;
assertTrue("Actual time: " + time 
         + ". Target time: " + expected, time <= expected);
```

**Better:** Use JUnit extension – *JUnitPerf*

- Uses decorator pattern
- Keeps timing code separate from testing

You can use JUnit for performance testing units, but beware that such tests are non-deterministic.  The performance of a DOM parser, for instance, is highly dependant on the amount of memory on the machine it is running on.  So these tests are most useful when making comparisons on the same development machine.  Even then, they can be affected by what software is running on that machine from one test to the next.  

A **JUnitPerf** test is a decorator that wraps an ordinary JUnit test.  In this example, there is a JUnit class `DOMTraxTransTest`, which tests a an XML DOM transformation using the Crimson parser: 

```java
import junit.framework.Test;
import com.clarkware.junitperf.TimedTest;

public class DOMTraxPerfTest {
    public static Test suite() {
        long maxElapsedTime = 3000;
        DOMTraxTransTest testCase =
             new DOMTraxTransTest("testCrimsonDOMTransform");
        Test timedTest = new TimedTest(testCase, maxElapsedTime);
        return timedTest;
    }
}
```
