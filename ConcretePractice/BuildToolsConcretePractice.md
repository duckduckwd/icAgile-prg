# Build Tools - Concrete Practice

## Task 1

* Import Calculator project into your workspace (Eclipse Workspace)

* Right-click on the Java Project -> choose configure - Convert to Maven project -> Finish

* You should see an xml file (pom.xml)  created for you automatically

## Task 2

Copy the below code into pom.xml within `<project> </project>` section

```xml
<dependencies>
   <dependency>
       <groupId>junit</groupId>
       <artifactId>junit</artifactId>
       <version>4.12</version>
       <scope>test</scope>
   </dependency>
</dependencies>
```

Maven should download all the require jar files into Maven Dependencies.
