# Introduction to Continuous Integration

## What is Continuous Integration

- Building software and exercising it with as many tests as possible

As Martin Fowler put it in his article [Continuous Integration](http://martinfowler.com/articles/continuousIntegration.html):

>Continuous Integration is a software development practice where members of a team integrate their work frequently, usually each person integrates at least daily - leading to multiple integrations per day. Each integration is verified by an automated build (including test) to detect integration errors as quickly as possible. Many teams find that this approach leads to significantly reduced integration problems and allows a team to develop cohesive software more rapidly. This article is a quick overview of Continuous Integration summarizing the technique and its current usage.

## How Does it Work

- Developers work on a new feature
- It is added to the main code base automatically
- Test driven development methodologies used to verify feature works and doesn’t break anything
- Automating the build process

---

## Why use Continuous Integration

### 1. Frequent Automated Testing

- Code bases that integrate new features are [and should be] tested every time they are built
  - CI tools facilitate and run tests on each integration reporting failures
    - Can also report on test code coverage
- Adds another fast-feedback loop to the development process
- Bugs and build fails are identified, stopping them being merged into the deployment branch so software becomes more reliable when released

### 2. Build and Deploy Code

- CI tools can automatically test, build and deploy a tested branch of a repository
- Notifications given for failures
- Build speeds are increased due to parallel build support (in some tools)

### 3. Increased Transparency

- Entire team can be aware of status of builds and tests
  - Can raise issues and plan work accordingly
- Patterns in integrating types of features can be identified and acted on

---

## Best Practices for Continuous Integration

1. Maintain a Single Source Repository

   - No more emailing code around!
   - Should contain everything required for the build including test and compilation scripts

2. Everyone Commits To the Mainline Every Day

   - Commit each change when it works

Adapted from Martin Fowler's article [Continuous Integration](http://martinfowler.com/articles/continuousIntegration.html)

## CI Tools (in no particular order)

1. [Jenkins](https://jenkins.io/) - a free, open-source too with a very active community
2. [circleci](https://circleci.com) - free tiers available, charged options for volume users
3. [TeamCity](https://www.jetbrains.com/teamcity/) - maintained by the JetBrains team, it has free and paid-for services
4. [Bamboo](https://www.atlassian.com/software/bamboo) - part of the Atlassian suite of development tools and services, a paid-for service
5. [GitLab](https://gitlab.com/) - can be configured to use their services or on your own choice (in-house or cloud-based), with free and paid-for services
6. [TravisCI](https://travis-ci.com) - free for open-source project, private projects are chargeable
