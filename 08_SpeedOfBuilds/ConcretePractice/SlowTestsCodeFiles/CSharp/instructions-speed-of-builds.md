# Speed of Builds exercise

* Work in pairs.

For this exercise you will be working on the **SpeedOfBuilds\Starer** folder. Open it.

## To Do

1. Identify fast and slow running tests then separate these tests into two test case classes like below

```csharp
public class FastUnitTests {

}

public class SlowUnitTests {


}
```

## Categorizing Tests

You can catyegorize your tests using a Trait attribute

```csharp
[Trait("Speed","Fast")]

[Fact]
public void Calculator_ShouldReturn0_WhenBalnkStringPassed()
{

}
```

Then when you run your tests from the command line using

`dotnet test --filter "Speed=Fast"`
