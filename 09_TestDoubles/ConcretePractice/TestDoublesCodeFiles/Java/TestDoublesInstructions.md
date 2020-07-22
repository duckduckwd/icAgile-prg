# Test Doubles (Java)

## Objectives

The objective of this lab is to see the different ways of manually implementing dependency injection and using EasyMock.

## Reference material

This exercise is based on material from the chapter Test Doubles.

## Overview

You will complete one exercise where you will:

* Write a class with a dependency on a class that does not exist yet;
* Create a new class to mimic the dependency –our “stub” class-
* Perform Dependency Injection using Setter Injection
  
*Whole Activity Time Box:* **20 minutes**

## Exercise 1 - EasyMock

### Objective

The objective of this task is to use EasyMock to test a given interface/class.In order to use EasyMock we will need to download some files (instructor will also have these files available).

* [EasyMock](http://easymock.org/)
* [Objenesis](http://objenesis.org/download.html)
* [cglib](https://github.com/cglib/cglib/releases/tag/RELEASE_3_2_7)

### Step 1

Create a new **Maven** java project and call it TestingEasyMock.

### Step 2

Create package *com.qa.testing.easymock* in the *src/main/javafolder*

### Step 3

Create the following enums/classes/interfaces:

#### Position.java

```java
package com.qa.testing.easymock;

public enum Position {
    BOSS, PROGRAMMER, SURFER;
}

```

#### ICalcMethod.java

```java
package com.qa.testing.easymock;

public interface ICalcMethod {
    doublecalc(Position position);
}

```

#### IncomeCalculator.java

```java
package com.qa.testing.easymock;

public class IncomeCalculator {
    private ICalcMethod calcMethod;
    private Position position;

    public void setCalcMethod(ICalcMethod calcMethod) {
        this.calcMethod= calcMethod;
    }

    public void setPosition(Position position) {
        this.position= position;
    }

    public double calc() {
        if(calcMethod== null) {
            throw new RuntimeException("CalcMethod not yet maintained");
        }
        if(position== null) {
            throw new RuntimeException("Position not yet maintained");
        }
        return calcMethod.calc(position);
    }
}

```

### Step 4

Locate *src/main/testfolder*.
Create a new unit test case for the `IncomeCalculator` and place this inside the test folder:

#### IncomeCalculatorTest.java

```java
import staticorg.easymock.EasyMock.createNiceMock;
import staticorg.easymock.EasyMock.expect;
import staticorg.easymock.EasyMock.replay;
import staticorg.easymock.EasyMock.verify;
import staticorg.junit.Assert.assertEquals;
import staticorg.junit.Assert.fail;
import org.junit.Before;
import org.junit.Test;
import com.qa.testing.easymock.ICalcMethod;
import com.qa.testing.easymock.IncomeCalculator;
import com.qa.testing.easymock.Position;

public class IncomeCalculatorTest {
    privateICalcMethod calcMethod
    privateIncomeCalculator calc;

    @Before
    public void setUp() throwsException {
        // NiceMocks return default values for unimplemented methods
        calcMethod= createNiceMock(ICalcMethod.class);
        calc= newIncomeCalculator();
    }

    @Test
    public void testCalc1() {
        // Setting up the expected value of the method call calc
        expect(calcMethod.calc(Position.BOSS)).andReturn(70000.0).times(2);
        expect(calcMethod.calc(Position.PROGRAMMER)).andReturn(50000.0);

        // Setup is finished need to activate the mock
        replay(calcMethod);
        calc.setCalcMethod(calcMethod);
        try{
            calc.calc();
            fail("Exception did not occur");
        } catch(RuntimeException e) {}

        calc.setPosition(Position.BOSS);
        assertEquals(70000.0, calc.calc(), 0);
        assertEquals(70000.0, calc.calc(), 0);

        calc.setPosition(Position.PROGRAMMER);
        assertEquals(50000.0, calc.calc(), 0);
        calc.setPosition(Position.SURFER);
        verify(calcMethod);
    }

    @Test(expected = RuntimeException.class)
    public void testNoCalc() {
        calc.setPosition(Position.SURFER);
        calc.calc();
    }

    @Test(expected = RuntimeException.class)
    public void testNoPosition() {
        expect(calcMethod.calc(Position.BOSS)).andReturn(70000.0);
        replay(calcMethod);
        calc.setCalcMethod(calcMethod);
        calc.calc();
    }

    @Test(expected = RuntimeException.class)
    public void testCalc2() {
        // Setting up the expected value of the method call calc
        expect(calcMethod.calc(Position.SURFER)).andThrow(newRuntimeException("Don't know this guy")).times(1);
        // Setup is finished need to activate the mock
        replay(calcMethod);
        calc.setPosition(Position.SURFER);
        calc.setCalcMethod(calcMethod);
        calc.calc();
    }
}

```

### Step 5

Run the test.
