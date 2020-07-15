# Speed of Builds exercise

Work in pairs.

Change your workspace to SpeedOfBuilds using File-> Switch Workspace in Eclipse

For this exercise you will be working on the SpeedOfBuilds project located in the Speed of builds folder.

## Task 1

Identify fast and slow running tests then separate these tests into two test case classes like below

```java
public class FastUnitTests {

    @Test
    public void aQuickTest(){
        [..code that finishes in milliseconds...]
    }

    @Test
    public void bQuickTest(){
        [..code that finishes in milliseconds...]
    }

}


public class SlowUnitTests {

    @Test
    public void lengthyUnitTest() {
        [...code that is very slow..]
    }

}
```

## Task 2 and Demo

Split unit tests using Surefire Maven plugin

Instruct Maven to run these tests with different profiles

Modify pom.xml file by adding below code, this will configure Fast running tests

```xml
<build>
        <plugins>
            <plugin>
                <groupId>org.apache.maven.plugins</groupId>
                <artifactId>maven-surefire-plugin</artifactId>
                <version>2.19.1</version>
                <configuration>
                    <includes>
                        <include>**/*Fast*</include>
                    </includes>
                </configuration>
            </plugin>
        </plugins>
</build>
```

Now Maven looks only at the tests that have the word Fast somewhere in test class name.

(Example: FastUnitTests)

## Task 3 - If you have time

Add the below code to configure slow running tests

```xml
  <profiles>
        <profile>
            <id>slow-tests</id>
            <build>
                <plugins>
                    <plugin>
                        <groupId>org.apache.maven.plugins</groupId>
                        <artifactId>maven-surefire-plugin</artifactId>
                        <version>2.19.1</version>
                        <configuration>
                            <includes>
                                <include>**/*Slow*</include>
                            </includes>
                        </configuration>
                    </plugin>
                </plugins>
            </build>
        </profile>
    </profiles>
```

Now Maven looks only at the tests that have the word Slow somewhere in test class name.

(Example: SlowUnitTests)

The following are the potential Maven commands to instruct Maven to split the pipeline

1) `mvn compile` (as before),
2) `mvn test` (for fast tests only),
3) `mvn test -Pslow-tests` (for slow tests only).
