# Build Tools

## Automated Build Tools

There are various build tools that help to produce an automated build and version control.  Some of the popular ones are:

- Apache Ant
- Apache Maven (Successor to Ant)
- Gradle

Build automation allows automating the creation of a software build and the associated processes which could include:

- Compiling, packing and running automated tests

---

## Why use Automated Build Tools

Developers often manually do the build process. On large projects this is not practical, it is hard to keep track of dependencies, what needs to be built, the sequence of the build. Using an automation tool allows this build process to be easier and more consistent.

Dependency management:

- Where to look for dependencies

Access control

- Access what projects depend on you and control visibility and access

Custom control

- Allows custom build mechanisms allowing custom archives to be built

Packaging

- Package the compiled source code

Running tests

---

## What are Build Managers?

Build managers automate building your project

- Repeatable
- Automatically running the tests
- Provides reports on builds passing or failing
- Capable of building code bases on different architectures

Tie in with build automation tools

- Maven / Gradle / SBT etc.
- Resolve all dependencies for a project

---

## Different Build Managers

### Jenkins

- Java based
- Create your own server
- Created from the Hudson project
- Very popular, well supported, a plugin for anything

### Hudson

- Original Jenkins project, owned by Oracle

### CircleCI & TravisCI

- Integration with github straight away
- Online service

### Cruise Control

- One of the first build managers
- Integration with ant, make maven etc.

### Ant / Make etc

- Original build managers for C/C++ projects and multi language projects

---

## Requirements for Build Managers

Needs to be capable of:

- Notice changes in source code
- Get a copy of the source code
- Build it (resolving dependencies)
- Test it
- Start deployment of code (often using docker, chef, puppet etc.)
- Provide some big visible charts showing the status of all the projects  

---

<!-- # Using Maven in Eclipse

Tutor Demonstration of Maven project

Explanation of POM file

Dependency management -->

## Using a Build Manager

Dependent on your trainer's area of expertise they will demonstrate:

- The use of a build manager
- How dependencies for a project are recorded and stored
- How dependencies can be managed

The following links may be of use for different environments:

NuGet - C# and Visual Studio - [https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio]

Maven - Java - [http://maven.apache.org/guides/getting-started/maven-in-five-minutes.html]

npm - JavaScript - [https://docs.npmjs.com/using-npm-packages-in-your-projects]

pip - Python - [https://packaging.python.org/tutorials/installing-packages/]

---

## Build Maagers and Version Control are part of CI/CD

What is CI/CD?

## Continuous Integration

- Developers work on a new feature
- It is added to the main code base automatically
- Test driven development methodologies used to verify feature works and doesn’t break anything
- Automating the build process

## Continuous Deployment / Delivery

- Successful, repeatable deployment of code
- After the build has run and been verified then deploy to server
- Automate the server setup / connection
- Code releases can be minute by minute, rather than months at a time

---

## Best Practices – Continuous Integration

### Maintain a Single Source Repository

- No more emailing code around!
- Should contain everything required for the build including test and compilation scripts

### Everyone Commits To the Mainline Every Day

- Commit each change when it works

Adapted From: http://martinfowler.com/articles/continuousIntegration.html

---

## Best Practices – Building and Testing

- Automate the build
  - Don’t allow human error to miss steps or get the wrong libraries!

- Make the build self-testing
  - Follow TDD principles, everything that can be tested should be

- Test in a Clone of the Production Environment
  - Test environment should mimic the production

- Every Commit Should Build the Mainline on an Integration Machine
  - This is where CI tools come in handy
  - Each commit should trigger a build – fail fast again

- Keep the Build Fast
  - Nothing is more dull than watching the build process
  - If the build is slow then people won’t commit code until they have to

---

## Best Practices - Culture

- Fix Broken Builds Immediately
  - Everyone should be involved with fixing problems

- Make it Easy for Anyone to Get the Latest Executable
  - Make it possible to allow people to demo the code
  - Everyone is using the same current copy

- Everyone can see what's happening
  - Communication!
  - Big Visible Charts!
  - This is the CI/CD version of agile best practices. Everyone should be informed at all times

- Automate Deployment
  - Set off deployment scripts
  - Repeatable, testable ideas

---

## Tools for the job

We will need tools for both the integration and development side

### Source control

Deals with the integration of code from one or more person
We will be using git based source control
Alternatives exist:

- Subversion (svn)
- Mercurial
- Team Foundation Server

### Build Tools (again!)

- Realises a change has occurred in the code base
- Clones the code
- Compiles, runs test and reports if there was a success or failure
